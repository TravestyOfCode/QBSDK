using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CreditCardTxnResultInfo", Namespace="", AnonymousType=true)]
    [XmlRoot("CreditCardTxnResultInfo", Namespace="")]
    public class CreditCardTxnResultInfo
    {        
        [Required()]
        [XmlElement("ResultCode")]
        public int ResultCode { get; set; }
        
        [MaxLength(60)]
        [Required()]
        [XmlElement("ResultMessage")]
        public string ResultMessage { get; set; }
        
        [MaxLength(24)]
        [Required()]
        [XmlElement("CreditCardTransID")]
        public string CreditCardTransID { get; set; }
        
        [MaxLength(32)]
        [Required()]
        [XmlElement("MerchantAccountNumber")]
        public string MerchantAccountNumber { get; set; }
        
        [MaxLength(12)]
        [XmlElement("AuthorizationCode")]
        public string AuthorizationCode { get; set; }
        
        [XmlElement("AVSStreet")]
        public AVSStreet? AVSStreet { get; set; }
        
        [XmlIgnore()]
        public bool AVSStreetSpecified { get; set; }
        
        [XmlElement("AVSZip")]
        public AVSZip? AVSZip { get; set; }
        
        [XmlIgnore()]
        public bool AVSZipSpecified { get; set; }
        
        [XmlElement("CardSecurityCodeMatch")]
        public CardSecurityCodeMatch? CardSecurityCodeMatch { get; set; }
        
        [XmlIgnore()]
        public bool CardSecurityCodeMatchSpecified { get; set; }
        
        [MaxLength(84)]
        [XmlElement("ReconBatchID")]
        public string ReconBatchID { get; set; }
        
        [XmlElement("PaymentGroupingCode")]
        public int PaymentGroupingCode { get; set; }
        
        [Required()]
        [XmlElement("PaymentStatus")]
        public PaymentStatus? PaymentStatus { get; set; }
        
        [Required()]
        [XmlElement("TxnAuthorizationTime")]
        public DateTime TxnAuthorizationTime { get; set; }
        
        [XmlElement("TxnAuthorizationStamp")]
        public int TxnAuthorizationStamp { get; set; }
        
        [MaxLength(16)]
        [XmlElement("ClientTransID")]
        public string ClientTransID { get; set; }
    }
}
