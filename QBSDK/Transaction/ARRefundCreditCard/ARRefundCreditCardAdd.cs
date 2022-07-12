using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ARRefundCreditCardAdd", Namespace="", AnonymousType=true)]
    [XmlRoot("ARRefundCreditCardAdd", Namespace="")]
    public class ARRefundCreditCardAdd
    {        
        [Required()]
        [XmlElement("CustomerRef")]
        public CustomerRef CustomerRef { get; set; }
        
        [XmlElement("RefundFromAccountRef")]
        public RefundFromAccountRef RefundFromAccountRef { get; set; }
        
        [XmlElement("ARAccountRef")]
        public ARAccountRef ARAccountRef { get; set; }
        
        [XmlElement("TxnDate")]
        public DateTime? TxnDate { get; set; }

        [XmlIgnore()]
        public bool TxnDateSpecified => TxnDate.HasValue;

        [MaxLength(11)]
        [XmlElement("RefNumber")]
        public string RefNumber { get; set; }
        
        [XmlElement("Address")]
        public Address Address { get; set; }
        
        [XmlElement("PaymentMethodRef")]
        public PaymentMethodRef PaymentMethodRef { get; set; }
        
        [MaxLength(4095)]
        [XmlElement("Memo")]
        public string Memo { get; set; }
        
        [XmlElement("CreditCardTxnInfo")]
        public CreditCardTxnInfo CreditCardTxnInfo { get; set; }
        
        [XmlElement("ExchangeRate")]
        public float ExchangeRate { get; set; }
        
        [RegularExpression("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [XmlElement("ExternalGUID")]
        public string ExternalGUID { get; set; }
        
        [XmlIgnore()]
        private Collection<RefundAppliedToTxnAdd> _refundAppliedToTxnAdd;
        
        [Required()]
        [XmlElement("RefundAppliedToTxnAdd")]
        public Collection<RefundAppliedToTxnAdd> RefundAppliedToTxnAdd
        {
            get => _refundAppliedToTxnAdd;
            private set => _refundAppliedToTxnAdd = value;
        }
                
        [XmlAttribute("defMacro")]
        public string DefMacro { get; set; }

        public ARRefundCreditCardAdd()
        {
            _refundAppliedToTxnAdd = new Collection<RefundAppliedToTxnAdd>();
        }
    }
}
