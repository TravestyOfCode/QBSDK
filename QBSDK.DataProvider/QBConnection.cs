using QBSDK;
using System.Reflection;
using System.Xml.Linq;

namespace QBSDK.DataProvider
{
    public class QBConnection
    {
        public string CompanyFile { get; set; }

        public string AppName { get; set; }

        public QBDataSet<Account> Accounts { get; set; }

        public QBConnection()
        {
            AppName = Assembly.GetCallingAssembly().GetName().Name;
            Accounts = new QBDataSet<Account>(this);
        }

        public QBConnection(string appName, string companyFile = null)
        {
            AppName = appName;
            CompanyFile = companyFile;
        }

        public XDocument ProcessRequest(XElement QBXMLMsgsRq)
        {
            throw new System.NotImplementedException();
        }
    }
}
