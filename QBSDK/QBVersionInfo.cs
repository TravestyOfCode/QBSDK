using System;

namespace QBSDK
{
    public class QBVersionInfo
    {
        public Version Version { get; internal set; }

        public string CountryCode { get; set; }

        public QBVersionInfo()
        {
            Version = new Version(13, 0);
            CountryCode = "US";
        }
    }
}
