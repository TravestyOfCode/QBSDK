using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CustomerRef", Namespace="", AnonymousType=true)]
    [XmlRoot("CustomerRef", Namespace="")]
    public class CustomerRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(209)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
