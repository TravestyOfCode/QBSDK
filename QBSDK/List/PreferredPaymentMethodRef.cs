using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("PreferredPaymentMethodRef", Namespace="", AnonymousType=true)]
    [XmlRoot("PreferredPaymentMethodRef", Namespace="")]
    public class PreferredPaymentMethodRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(31)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}