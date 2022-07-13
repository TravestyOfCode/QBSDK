using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CreditCardTxnInputInfo", Namespace="", AnonymousType=true)]
    [XmlRoot("CreditCardTxnInputInfo", Namespace="")]
    public class CreditCardTxnInputInfo
    {
        [MaxLength(25)]
        [Required()]
        [XmlElement("CreditCardNumber")]
        public string CreditCardNumber { get; set; }
        
        [Range(typeof(int), "1", "12")]
        [Required()]
        [XmlElement("ExpirationMonth")]
        public int ExpirationMonth { get; set; }
        
        [Required()]
        [XmlElement("ExpirationYear")]
        public int ExpirationYear { get; set; }
        
        [MaxLength(41)]
        [Required()]
        [XmlElement("NameOnCard")]
        public string NameOnCard { get; set; }
        
        [MaxLength(41)]
        [XmlElement("CreditCardAddress")]
        public string CreditCardAddress { get; set; }
        
        [MaxLength(18)]
        [XmlElement("CreditCardPostalCode")]
        public string CreditCardPostalCode { get; set; }
        
        [MaxLength(24)]
        [XmlElement("CommercialCardCode")]
        public string CommercialCardCode { get; set; }
        
        [XmlElement("TransactionMode")]
        public TransactionMode? TransactionMode { get; set; }

        [XmlIgnore()]
        public bool TransactionModeSpecified => TransactionMode.HasValue;
        
        [XmlElement("CreditCardTxnType")]
        public CreditCardTxnType? CreditCardTxnType { get; set; }
        
        [XmlIgnore()]
        public bool CreditCardTxnTypeSpecified { get; set; }
    }
}
