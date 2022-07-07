using System;
using System.Xml.Linq;

namespace QBSDK
{
    public abstract class QBObject : IQBXMLRq
    {
        internal int? requestID { get; set; }

        internal string ID { get; set; }

        public string StatusCode { get; internal set; }

        public string StatusMessage { get; internal set; }

        public string EditSequence { get; set; }

        public DateTime? TimeCreated { get; internal set; }

        public DateTime? TimeModified { get; internal set; }

        public abstract void Parse(XElement ret);

        public abstract XElement ToAddRq(QBVersionInfo versionInfo = null);

        public abstract XElement ToModRq(QBVersionInfo versionInfo = null);

        public abstract XElement ToDelRq(QBVersionInfo versionInfo = null);
    }
}