using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AccountAdd", Namespace = "", AnonymousType = true)]
    [XmlRoot("AccountAdd", Namespace = "")]
    public class AccountAdd
    {
        [MaxLength(31)]
        [Required()]
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("IsActive")]
        internal string IsActiveString
        {
            get => IsActive == null ? null : (IsActive.Value ? "true" : "false");
            set => IsActive = value == null ? null : value == "true";
        }

        [XmlIgnore()]
        public bool? IsActive { get; set; }

        [XmlElement("ParentRef")]
        public ParentRef ParentRef { get; set; }

        [Required()]
        [XmlElement("AccountType")]
        public AccountType AccountType { get; set; }

        [XmlElement("DetailAccountType")]
        public DetailAccountType? DetailAccountType { get; set; }

        [XmlIgnore()]
        public bool DetailAccountTypeSpecified => DetailAccountType.HasValue;

        [MaxLength(7)]
        [XmlElement("AccountNumber")]
        public string AccountNumber { get; set; }

        [MaxLength(25)]
        [XmlElement("BankNumber")]
        public string BankNumber { get; set; }

        [MaxLength(200)]
        [XmlElement("Desc")]
        public string Desc { get; set; }

        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("OpenBalance")]
        public string OpenBalance { get; set; }

        [XmlElement("OpenBalanceDate")]
        public string OpenBalanceDate { get; set; }

        [XmlElement("SalesTaxCodeRef")]
        public SalesTaxCodeRef SalesTaxCodeRef { get; set; }

        [XmlElement("TaxLineID")]
        public int? TaxLineID { get; set; }

        [XmlElement("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }
    }
}
