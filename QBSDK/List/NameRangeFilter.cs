using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("NameRangeFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("NameRangeFilter", Namespace="")]
    public class NameRangeFilter
    {   
        [XmlElement("FromName")]
        public string FromName { get; set; }
        
        [XmlElement("ToName")]
        public string ToName { get; set; }
    }
}
