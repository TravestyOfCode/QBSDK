using Microsoft.EntityFrameworkCore;
using QBSDK.Lists;
using QBXMLRP2Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QBSDK
{
    public class QBDBContext : DbContext
    {
        private IRequestProcessor5 _rp;

        private string ticket;

        public string CompanyName { get; set; }

        public string AppName { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public QBDBContext(string appName, string companyName = null)
        {
            AppName = appName;
            CompanyName = companyName;
        }

        private void Open()
        {
            if (_rp == null)
            {
                _rp = new RequestProcessor3();
            }

            if (!string.IsNullOrEmpty(ticket))
            {
                if (IsOpenToCompanyFile())
                {
                    return;
                }
            }

            Close();

            _rp.OpenConnection2(AppName, AppName, QBXMLRPConnectionType.localQBD);

            ticket = _rp.BeginSession(CompanyName, QBFileMode.qbFileOpenDoNotCare);
        }

        private void Close()
        {
            if(!string.IsNullOrEmpty(ticket))
            {
                try
                {
                    _rp.EndSession(ticket);
                }
                catch
                {

                }
            }

            if(_rp != null)
            {
                try
                {
                    _rp.CloseConnection();
                }
                catch
                {

                }
            }

            ticket = null;
            _rp = null;
        }

        private bool IsOpenToCompanyFile()
        {
            try
            {
                string currentFile = _rp.GetCurrentCompanyFileName(ticket);

                if(string.IsNullOrEmpty(CompanyName))
                {
                    return true;
                }

                return Path.GetFullPath(currentFile).Equals(Path.GetFullPath(CompanyName));
            }
            catch
            {
                return false;
            }
        }

        public override int SaveChanges()
        {
            return SaveChanges(true);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            XElement QBXMLMsgsRq = new XElement(nameof(QBXMLMsgsRq));

            int requestID = 1;

            foreach (var entity in ChangeTracker.Entries().Where(e => e.Entity is QBObject))
            {
                ((QBObject)entity.Entity).requestID = requestID++;

                switch (entity.State)
                {
                    case EntityState.Added:
                        QBXMLMsgsRq.Add(((QBObject)entity.Entity).ToAddRq());
                        break;
                    case EntityState.Modified:
                        QBXMLMsgsRq.Add(((QBObject)entity.Entity).ToModRq());
                        break;

                    case EntityState.Deleted:
                        QBXMLMsgsRq.Add(((QBObject)entity.Entity).ToDelRq());
                        break;
                }
            }

            var doc = ProcessRequest(QBXMLMsgsRq);

            return ProcessResponse(doc);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return SaveChangesAsync(true, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(SaveChanges(true));
        }

        public XDocument ProcessRequest(XElement QBXMLMsgsRq)
        {
            var doc = CreateQBXML(QBXMLMsgsRq);
            string response;
            try
            {
                Open();

                response = _rp.ProcessRequest(ticket, doc.ToString());
            }
            catch
            {
                Close();
                throw;
            }

            Close();

            return XDocument.Parse(response);
        }

        public DbSet<TEntity> ProcessQuery<TEntity>(XElement QBXMLMsgsRq) where TEntity : QBObject
        {
            if (QBXMLMsgsRq == null)
                return null;

            foreach(var QueryRs in QBXMLMsgsRq.Elements())
            {
                // Ensure we are working with some query response (not an Add/Mod/Del response
                if (!QueryRs.Name.LocalName.EndsWith(nameof(QueryRs)))
                    continue;

                // Get the statusCode/Message for this query
                string statusCode = QueryRs.Attribute(nameof(statusCode))?.Value;
                string statusMessage = QueryRs.Attribute(nameof(statusMessage))?.Value;

                // If we don't have a stauts, something went really wrong
                if (string.IsNullOrEmpty(statusCode))
                    continue;

                // For each of the Ret elements, create an object, parse, and add to our DBSet
                DbSet<TEntity> dbSet = this.Set<TEntity>();
                foreach(var Ret in QueryRs.Elements())
                {
                    TEntity obj = default;
                    obj.StatusCode = statusCode;
                    obj.StatusMessage = statusMessage;
                    obj.Parse(Ret);
                    dbSet.Add(obj);
                }
                
                return dbSet;
            }

            return null;
        }

        private int ProcessResponse(XDocument doc)
        {
            int success = 0;

            foreach(var QBXMLMsgsRs in doc.Descendants("QBXMLMsgsRs"))
            {
                foreach (var ret in QBXMLMsgsRs.Elements())
                {
                    // Get the requestID
                    if (int.TryParse(ret.Attribute("requestID")?.Value, out int requestID))
                    {
                        // Try to locate this request in our change tracker
                        var entity = ChangeTracker.Entries()
                            .Where(e => e.Entity is QBObject qbObject && qbObject.requestID == requestID)
                            .SingleOrDefault();

                        if (entity == null)
                            continue;

                        QBObject qbo = entity.Entity as QBObject;

                        qbo.StatusCode = ret.Attribute("statusCode")?.Value;
                        qbo.StatusMessage = ret.Attribute("statusMessage")?.Value;

                        if (qbo.StatusCode != "0")
                        {
                            // Save failed, move on
                            continue;
                        }

                        qbo.Parse(ret);

                        entity.State = EntityState.Unchanged;

                        success++;
                    }
                }
            }

            return success;
        }

        private static XDocument CreateQBXML(XElement QBXMLMsgsRq)
        {
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", null));
            doc.Add(new XProcessingInstruction("qbxml", "version=\"13.0\""));
            doc.Add(new XElement("QBXML", QBXMLMsgsRq));
            return doc;
        }
    }
}
