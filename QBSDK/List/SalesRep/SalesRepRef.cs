using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("SalesRepRef", Namespace="", AnonymousType=true)]
    [XmlRoot("SalesRepRef", Namespace="")]
    public class SalesRepRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(5)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
