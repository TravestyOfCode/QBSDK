using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public abstract class QBObject : IQBXMLRq
    {
#pragma warning disable IDE1006 // Naming Styles - We use nameof(requestID) and QB requires to start with lowercase
        internal int? requestID { get; set; }
#pragma warning restore IDE1006 // Naming Styles

        internal string ID { get; set; }

        public string StatusCode { get; internal set; }

        public string StatusMessage { get; internal set; }

        public string EditSequence { get; set; }

        public DateTime? TimeCreated { get; internal set; }

        public DateTime? TimeModified { get; internal set; }

        protected List<string> IncludeRetElement;
        public List<string> IncludeRetElementList
        {
            get => IncludeRetElement;
            set => IncludeRetElement = value;
        }

        public abstract void Parse(XElement ret);

        public abstract XElement ToAddRq(QBVersionInfo versionInfo = null);

        public abstract XElement ToModRq(QBVersionInfo versionInfo = null);

        public abstract XElement ToDelRq(QBVersionInfo versionInfo = null);
    }
}