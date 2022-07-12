using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("RefundAppliedToTxnAdd", Namespace="", AnonymousType=true)]
    [XmlRoot("RefundAppliedToTxnAdd", Namespace="")]
    public class RefundAppliedToTxnAdd
    {        
        [Required()]
        [XmlElement("TxnID")]
        public RefundAppliedToTxnAddTxnID TxnID { get; set; }
        
        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [Required()]
        [XmlElement("RefundAmount")]
        public decimal RefundAmount { get; set; }
    }
}
