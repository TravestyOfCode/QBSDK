using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CustomerTypeRef", Namespace="", AnonymousType=true)]
    [XmlRoot("CustomerTypeRef", Namespace="")]
    public class CustomerTypeRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(159)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
