using Mapster;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ARRefundCreditCard")]
    [XmlRoot("ARRefundCreditCard")]
    public class ARRefundCreditCard
    {
        [MaxLength(36)]
        [XmlElement("TxnID")]
        public string TxnID { get; set; }

        [XmlElement("TimeCreated")]
        public DateTime? TimeCreated { get; set; }

        [XmlIgnore()]
        public bool TimeCreatedSpecified => TimeCreated.HasValue;

        [XmlElement("TimeModified")]
        public DateTime? TimeModified { get; set; }

        [XmlIgnore()]
        public bool TimeModifiedSpecified => TimeModified.HasValue;

        [MaxLength(16)]
        [XmlElement("EditSequence")]
        public string EditSequence { get; set; }

        [XmlElement("TxnNumber")]
        public string TxnNumber { get; set; }

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

        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("TotalAmount")]
        public decimal? TotalAmount { get; set; }

        [XmlIgnore()]
        public bool TotalAmountSpecified => TotalAmount.HasValue;

        [XmlElement("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }

        [XmlElement("ExchangeRate")]
        public string ExchangeRate { get; set; }

        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("TotalAmountInHomeCurrency")]
        public decimal? TotalAmountInHomeCurrency { get; set; }

        [XmlIgnore()]
        public bool TotalAmountInHomeCurrencySpecified => TotalAmountInHomeCurrency.HasValue;

        [XmlElement("Address")]
        public Address Address { get; set; }

        [XmlElement("AddressBlock")]
        public AddressBlock AddressBlock
        {
            get => Address;
            set => Address = value.Adapt<Address>();
        }

        [XmlElement("PaymentMethodRef")]
        public PaymentMethodRef PaymentMethodRef { get; set; }

        [MaxLength(4095)]
        [XmlElement("Memo")]
        public string Memo { get; set; }

        [XmlElement("CreditCardTxnInfo")]
        public CreditCardTxnInfo CreditCardTxnInfo { get; set; }

        [RegularExpression("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [XmlElement("ExternalGUID")]
        public string ExternalGUID { get; set; }

        [XmlIgnore()]
        private Collection<RefundAppliedToTxnRet> _refundAppliedToTxnRet;

        [XmlElement("RefundAppliedToTxnRet")]
        public Collection<RefundAppliedToTxnRet> RefundAppliedToTxnRet
        {
            get => _refundAppliedToTxnRet;
            private set => _refundAppliedToTxnRet = value;
        }

        [XmlIgnore()]
        public bool RefundAppliedToTxnRetSpecified => RefundAppliedToTxnRet.Count != 0;
                
        [XmlIgnore()]
        private Collection<DataExtRet> _dataExtRet;

        [XmlElement("DataExtRet")]
        public Collection<DataExtRet> DataExtRet
        {
            get => _dataExtRet;
            private set => _dataExtRet = value;
        }

        [XmlIgnore()]
        public bool DataExtRetSpecified => DataExtRet.Count != 0;

        public ARRefundCreditCard()
        {
            _refundAppliedToTxnRet = new Collection<RefundAppliedToTxnRet>();
            _dataExtRet = new Collection<DataExtRet>();
        }

        public static implicit operator ARRefundCreditCardAdd(ARRefundCreditCard arRefundCreditCard) => arRefundCreditCard.Adapt<ARRefundCreditCardAdd>();

    }
}
