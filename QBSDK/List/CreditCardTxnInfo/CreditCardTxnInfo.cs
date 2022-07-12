using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CreditCardTxnInfo", Namespace="", AnonymousType=true)]
    [XmlRoot("CreditCardTxnInfo", Namespace="")]
    public class CreditCardTxnInfo
    {        
        [Required()]
        [XmlElement("CreditCardTxnInputInfo")]
        public CreditCardTxnInputInfo CreditCardTxnInputInfo { get; set; }
        
        [Required()]
        [XmlElement("CreditCardTxnResultInfo")]
        public CreditCardTxnResultInfo CreditCardTxnResultInfo { get; set; }
    }
}
