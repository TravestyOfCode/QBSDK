using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("RefundAppliedToTxnRet", Namespace="", AnonymousType=true)]
    [XmlRoot("RefundAppliedToTxnRet", Namespace="")]
    public class RefundAppliedToTxnRet
    {   
        [MaxLength(36)]
        [Required()]
        [XmlElement("TxnID")]
        public string TxnID { get; set; }
        
        [Required()]
        [XmlElement("TxnType")]
        public TxnType TxnType { get; set; }
        
        [Required()]
        [XmlElement("TxnDate")]
        public string TxnDate { get; set; }
        
        [MaxLength(20)]
        [XmlElement("RefNumber")]
        public string RefNumber { get; set; }
        
        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [Required()]
        [XmlElement("CreditRemaining")]
        public decimal CreditRemaining { get; set; }
        
        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [Required()]
        [XmlElement("RefundAmount")]
        public decimal RefundAmount { get; set; }
        
        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("CreditRemainingInHomeCurrency")]
        public decimal? CreditRemainingInHomeCurrency { get; set; }

        [XmlIgnore()]
        public bool CreditRemainingInHomeCurrencySpecified => CreditRemainingInHomeCurrency.HasValue;

        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("RefundAmountInHomeCurrency")]
        public decimal? RefundAmountInHomeCurrency { get; set; }

        [XmlIgnore()]
        public bool RefundAmountInHomeCurrencySpecified => RefundAmountInHomeCurrency.HasValue;
    }
}
