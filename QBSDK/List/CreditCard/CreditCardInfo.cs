using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CreditCardInfo", Namespace="", AnonymousType=true)]
    [XmlRoot("CreditCardInfo", Namespace="")]
    public class CreditCardInfo
    {        
        [MaxLength(25)]
        [XmlElement("CreditCardNumber")]
        public string CreditCardNumber { get; set; }
        
        [Range(typeof(int), "1", "12")]
        [XmlElement("ExpirationMonth")]
        public int? ExpirationMonth { get; set; }

        [XmlIgnore()]
        public bool ExpirationMonthSpecified => ExpirationMonth.HasValue;
        
        [XmlElement("ExpirationYear")]
        public string ExpirationYear { get; set; }
        
        [MaxLength(41)]
        [XmlElement("NameOnCard")]
        public string NameOnCard { get; set; }
        
        [MaxLength(41)]
        [XmlElement("CreditCardAddress")]
        public string CreditCardAddress { get; set; }
        
        [MaxLength(41)]
        [XmlElement("CreditCardPostalCode")]
        public string CreditCardPostalCode { get; set; }
    }
}
