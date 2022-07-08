using QBXMLRP2Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QBSDK
{
    public class QBConnection
    {
        private IRequestProcessor5 rp;

        private string ticket;

        public string CompanyFile { get; set; }

        public string AppName { get; set; }

        public QBConnection(string appName = null, string companyFile = null)
        {
            appName ??= Assembly.GetCallingAssembly().GetName().Name;
            AppName = appName;
            CompanyFile = companyFile;
        }

        public XDocument ProcessRequest(XElement request, bool stopOnError = true)
        {
            rp = new RequestProcessor3();
            rp.OpenConnection2(AppName, AppName, QBXMLRPConnectionType.localQBD);
            ticket = rp.BeginSession(CompanyFile, QBFileMode.qbFileOpenDoNotCare);

            string r = CreateQBXML(request, stopOnError ? "stopOnError" : "continueOnError");
            var response = rp.ProcessRequest(ticket, r);

            rp.EndSession(ticket);
            ticket = null;
            rp.CloseConnection();
            rp = null;

            XDocument doc = XDocument.Parse(response);

            return doc;
        }

        public List<T> ProcessQuery<T>(QBQuery<T> query, QBVersionInfo version = null) where T : QBObject, new()
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            version ??= new QBVersionInfo();

            XDocument doc = ProcessRequest(query.ToQueryRq(version));

            XElement QBXMLMsgsRs = doc.Descendants(nameof(QBXMLMsgsRs)).FirstOrDefault();

            if (QBXMLMsgsRs == null)
                throw new NullReferenceException("Processed request contains no QBXMLMsgsRs.");

            var QueryRs = QBXMLMsgsRs.Element($"{typeof(T).Name}QueryRs");
            if (QueryRs == null)
                throw new NullReferenceException($"No query response found for type: {typeof(T).Name}.");

            // Check the status
            string statusCode = QueryRs.Attribute(nameof(statusCode))?.Value;
            string statusMessage = QueryRs.Attribute(nameof(statusMessage))?.Value;

            if (statusCode == "1") // A query request did not find any matching entities
                return new List<T>();

            if (statusCode != "0")
                throw new QueryException(statusCode, statusMessage);

            // Set the iterator if we have one
            XAttribute iteratorID = QueryRs.Attribute(nameof(iteratorID));
            if (iteratorID != null)
            {
                query.iterator = Iterator.Continue;
                query.iteratorID = iteratorID.Value;
            }

            // For each of the Ret Elements, parse and add to our list
            List<T> results = new List<T>();
            foreach(var Ret in QueryRs.Elements())
            {
                T result = new T();
                result.Parse(Ret);
                results.Add(result);
            }

            return results;
        }

        private string CreateQBXML(XElement request, string onError = "stopOnError")
        {
            XDocument doc = new XDocument();
            doc.Add(new XProcessingInstruction("qbxml", "version=\"13.0\""));
            XElement QBXMLMsgsRq = new XElement(nameof(QBXMLMsgsRq), request);
            QBXMLMsgsRq.Add(new XAttribute(nameof(onError), onError));
            doc.Add(new XElement("QBXML", QBXMLMsgsRq));
            return "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + doc.ToString();
        }
    }
}
