using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("PriceLevelRef", Namespace="", AnonymousType=true)]
    [XmlRoot("PriceLevelRef", Namespace="")]
    public class PriceLevelRef
    {        
        [MaxLengthAttribute(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(31)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
