using Mapster;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AccountRet", Namespace = "", AnonymousType = true)]
    [XmlRoot("AccountRet", Namespace = "")]
    public class Account : IQBEntity
    {
        public Type AddType { get; init; } = typeof(AccountAdd);

        public Type ModType { get; init; } = typeof(AccountMod);

        public Type DelType { get; init; } = typeof(AccountDel);

        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }

        [XmlElement("TimeCreated")]
        public DateTime? TimeCreated { get; internal set; }

        [XmlElement("TimeModified")]
        public DateTime? TimeModified { get; internal set; }

        [MaxLength(16)]
        [XmlElement("EditSequence")]
        public string EditSequence { get; internal set; }

        [MaxLength(31)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [MaxLength(159)]
        [XmlElement("FullName")]
        public string FullName { get; set; }

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

        [XmlElement("Sublevel")]
        public int? Sublevel { get; internal set; }

        [XmlElement("AccountType")]
        public AccountType? AccountType { get; set; }

        [XmlElement("DetailAccountType")]
        public DetailAccountType? DetailAccountType { get; set; }

        [XmlElement("SpecialAccountType")]
        public SpecialAccountType? SpecialAccountType { get; set; }

        [XmlIgnore()]
        public bool? IsTaxAccount { get; set; }

        [XmlElement("IsTaxAccount")]
        internal string IsTaxAccountString => IsTaxAccount == null ? null : (IsTaxAccount.Value ? "true" : "false");
        
        [MaxLength(7)]
        [XmlElement("AccountNumber")]
        public string AccountNumber { get; set; }

        [MaxLength(25)]
        [XmlElement("BankNumber")]
        public string BankNumber { get; set; }

        [XmlElement("LastCheckNumber")]
        public string LastCheckNumber { get; set; }

        [MaxLength(200)]
        [XmlElement("Desc")]
        public string Desc { get; set; }

        [XmlElement("OpenBalance")]
        public decimal? OpenBalance { get; set; }

        [XmlElement("OpenBalanceDate")]
        public DateTime? OpenBalanceDate { get; set; }

        [XmlElement("Balance")]
        public decimal? Balance { get; set; }

        [XmlElement("TotalBalance")]
        public decimal? TotalBalance { get; set; }

        [XmlElement("SalesTaxCodeRef")]
        public SalesTaxCodeRef SalesTaxCodeRef { get; set; }

        [XmlElement("TaxLineInfoRet")]
        public TaxLineInfoRet TaxLineInfoRet { get; set; }

        [XmlElement("TaxLineID")]
        public int? TaxLineID
        {
            get => TaxLineInfoRet?.TaxLineID;
            set
            {
                if (value == null)
                    TaxLineInfoRet = null;
                else
                {
                    TaxLineInfoRet = new TaxLineInfoRet() { TaxLineID = value.Value };
                }
            }
        }

        [XmlElement("CashFlowClassification")]
        public CashFlowClassification? CashFlowClassification { get; set; }

        [XmlElement("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }

        [XmlIgnore()]
        private Collection<DataExt> _dataExtRet;

        [XmlElement("DataExtRet")]
        public Collection<DataExt> DataExtRet
        {
            get
            {
                return _dataExtRet;
            }
            private set
            {
                _dataExtRet = value;
            }
        }

        public Account()
        {
            _dataExtRet = new Collection<DataExt>();
        }

        public static implicit operator AccountAdd(Account account) => account.Adapt<AccountAdd>();

        public static implicit operator AccountMod(Account account) => account.Adapt<AccountMod>();

        public static implicit operator AccountDel(Account account) => account.Adapt<AccountDel>();
    }
}
