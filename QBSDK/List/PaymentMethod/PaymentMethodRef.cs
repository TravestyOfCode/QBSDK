using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("PaymentMethodRef", Namespace="", AnonymousType=true)]
    [XmlRoot("PaymentMethodRef", Namespace="")]
    public class PaymentMethodRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(31)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
