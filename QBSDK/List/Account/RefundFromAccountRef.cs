using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("RefundFromAccountRef", Namespace="", AnonymousType=true)]
    [XmlRoot("RefundFromAccountRef", Namespace="")]
    public class RefundFromAccountRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(159)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
