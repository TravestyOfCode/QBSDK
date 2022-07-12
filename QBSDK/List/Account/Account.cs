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

        [XmlElement("IsActive")]
        public bool? IsActive { get; set; }

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

        [XmlElement("IsTaxAccount")]
        public bool? IsTaxAccount { get; set; }

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
        private Collection<DataExtRet> _dataExtRet;

        [XmlElement("DataExtRet")]
        public Collection<DataExtRet> DataExtRet
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
            _dataExtRet = new Collection<DataExtRet>();
        }

        public static implicit operator AccountAdd(Account account) => account.Adapt<AccountAdd>();

        public static implicit operator AccountMod(Account account) => account.Adapt<AccountMod>();

        public static implicit operator AccountDel(Account account) => account.Adapt<AccountDel>();
    }

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
        public string IsActive { get; set; }

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
        public string TaxLineID { get; set; }

        [XmlElement("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }
    }

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

        [XmlElement("IsActive")]
        public bool? IsActive { get; set; }

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

    [Serializable()]
    [XmlType("ListDelRqType", Namespace = "")]
    public class AccountDel
    {
        [Required()]
        [XmlElement("ListDelType")]
        public ListDelType ListDelType { get; init; } = ListDelType.Account;

        [MaxLength(36)]
        [Required()]
        [XmlElement("ListID")]
        public string ListID { get; set; }

        [XmlAttribute("requestID")]
        public string RequestID { get; set; }
    }

    [Serializable()]
    [XmlType("AccountAddRq")]
    [XmlRoot("AccountAddRq")]
    public class AccountAddRq : Request<AccountAdd>
    {
        public AccountAdd AccountAdd { get; init; }

        internal AccountAddRq() { }

        public AccountAddRq(AccountAdd accountAdd)
        {
            AccountAdd = accountAdd;
        }
    }

    [Serializable()]
    [XmlType("AccountModRq")]
    [XmlRoot("AccountModRq")]
    public class AccountModRq : Request<AccountMod>
    {
        public AccountMod AccountMod { get; init; }

        internal AccountModRq() { }

        public AccountModRq(AccountMod accountMod)
        {
            AccountMod = accountMod;
        }
    }
}
