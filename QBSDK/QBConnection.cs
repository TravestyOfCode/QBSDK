using QBXMLRP2Lib;
using System;
using System.Reflection;

namespace QBSDK
{
    public class QBConnection
    {
        private IRequestProcessor5 RequestProcessor;

        private string Ticket;

        public string AppName { get; set; }

        public string CompanyFile { get; set; }

        public QBFileMode QBFileMode { get; set; }

        public string CurrentCompanyFile
        {
            get
            {
                if (RequestProcessor == null || Ticket == null)
                    return null;

                try
                {
                    return RequestProcessor.GetCurrentCompanyFileName(Ticket);
                }
                catch
                {
                    return null;
                }
            }
        }

        public QBConnection() : this(null, null)
        {            
        }

        public QBConnection(string appName = null, string companyFile = null)
        {
            appName ??= Assembly.GetCallingAssembly().GetName().Name;

            AppName = appName;

            CompanyFile = companyFile;
        }
    
        public void Open()
        {
            if (IsOpen())
                return;

            Close();

            // TODO: catch Exceptions and return friendlier errors;
            RequestProcessor ??= new RequestProcessor3();

            RequestProcessor.OpenConnection2(AppName, AppName, QBXMLRPConnectionType.localQBD);

            switch(QBFileMode)
            {
                case QBFileMode.MultiUser: Ticket = RequestProcessor.BeginSession(CompanyFile, QBXMLRP2Lib.QBFileMode.qbFileOpenMultiUser); break;
                case QBFileMode.SingleUser: Ticket = RequestProcessor.BeginSession(CompanyFile, QBXMLRP2Lib.QBFileMode.qbFileOpenSingleUser); break;
                case QBFileMode.DoNotCare: Ticket = RequestProcessor.BeginSession(CompanyFile, QBXMLRP2Lib.QBFileMode.qbFileOpenDoNotCare); break;
            }            
        }

        public void Close()
        {
            if (RequestProcessor != null)
            {
                if (Ticket != null)
                {
                    try
                    {
                        RequestProcessor.EndSession(Ticket);
                    }
                    catch { }
                }

                try
                {
                    RequestProcessor.CloseConnection();
                }
                catch { }
            }

            Ticket = null;
            RequestProcessor = null;
        }

        private bool IsOpen()
        {
            if (RequestProcessor == null || Ticket == null)
                return false;

            try
            {
                string currentCompanyFile = CurrentCompanyFile;

                if (currentCompanyFile != null)
                {
                    if (string.IsNullOrEmpty(CompanyFile))
                        return true;

                    return currentCompanyFile.Equals(CompanyFile, StringComparison.OrdinalIgnoreCase);
                }
            }
            catch { }

            return false;
        }

        public string ProcessRequest(string request)
        {
            Open();

            return RequestProcessor.ProcessRequest(Ticket, request);
        }
    }
}
