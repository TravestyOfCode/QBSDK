using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AccountMod", Namespace = "", AnonymousType = true)]
    [XmlRoot("AccountMod", Namespace = "")]
    public partial class AccountMod
    {
        [MaxLength(36)]
        [Required()]
        [XmlElement("ListID")]
        public string ListID { get; set; }

        [MaxLength(16)]
        [Required()]
        [XmlElement("EditSequence")]
        public string EditSequence { get; set; }

        [MaxLength(31)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlIgnore()]
        public bool? IsActive { get; set; }

        [XmlElement("IsActive")]
        internal string IsActiveString
        {
            get => IsActive == null ? null : (IsActive.Value ? "true" : "false");
            set => IsActive = value == null ? null : value == "true";
        }

        [XmlElement("ParentRef")]
        public ParentRef ParentRef { get; set; }

        [XmlElement("AccountType")]
        public AccountType? AccountType { get; set; }

        [MaxLength(7)]
        [XmlElement("AccountNumber")]
        public string AccountNumber { get; set; }

        [MaxLength(25)]
        [XmlElement("BankNumber")]
        public string BankNumber { get; set; }

        [MaxLength(200)]
        [XmlElement("Desc")]
        public string Desc { get; set; }

        [XmlElement("OpenBalance")]
        public decimal? OpenBalance { get; set; }

        [XmlIgnore()]
        public bool OpenBalanceSpecified => OpenBalance.HasValue;

        [XmlElement("OpenBalanceDate")]
        public DateTime? OpenBalanceDate { get; set; }

        [XmlIgnore()]
        public bool OpenBalanceDateSpecified => OpenBalanceDate.HasValue;

        [XmlElement("SalesTaxCodeRef")]
        public SalesTaxCodeRef SalesTaxCodeRef { get; set; }

        [XmlElement("TaxLineID")]
        public int? TaxLineID { get; set; }

        [XmlIgnore()]
        public bool TaxLineIDSpecified => TaxLineID.HasValue;

        [XmlElement("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }
    }
}
