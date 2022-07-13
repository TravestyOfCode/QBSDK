using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using Mapster;
using System.Collections.ObjectModel;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CustomerRet", Namespace="", AnonymousType=true)]
    [XmlRoot("CustomerRet", Namespace="")]
    public partial class Customer
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
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
        
        [MaxLength(41)]
        [XmlElement("Name")]
        public string Name { get; set; }
        
        [MaxLength(209)]
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
        
        [XmlElement("ClassRef")]
        public ClassRef ClassRef { get; set; }
        
        [XmlElement("ParentRef")]
        public ParentRef ParentRef { get; set; }
        
        [XmlElement("Sublevel")]
        public int Sublevel { get; internal set; }
        
        [MaxLength(41)]
        [XmlElement("CompanyName")]
        public string CompanyName { get; set; }
        
        [MaxLength(15)]
        [XmlElement("Salutation")]
        public string Salutation { get; set; }
        
        [MaxLength(25)]
        [XmlElement("FirstName")]
        public string FirstName { get; set; }
        
        [MaxLength(5)]
        [XmlElement("MiddleName")]
        public string MiddleName { get; set; }
        
        [MaxLength(25)]
        [XmlElement("LastName")]
        public string LastName { get; set; }
        
        [XmlElement("Suffix")]
        public string Suffix { get; set; }
        
        [MaxLength(41)]
        [XmlElement("JobTitle")]
        public string JobTitle { get; set; }
        
        [XmlElement("BillAddress")]
        public Address BillAddress { get; set; }
        
        [XmlElement("BillAddressBlock")]
        public AddressBlock BillAddressBlock
        {
            get => BillAddress;
            set => BillAddress = value.Adapt<Address>();
        }
        
        [XmlElement("ShipAddress")]
        public Address ShipAddress { get; set; }
        
        [XmlElement("ShipAddressBlock")]
        public AddressBlock ShipAddressBlock
        {
            get => ShipAddress;
            set => ShipAddress = value.Adapt<Address>();
        }
        
        [XmlIgnore()]
        private Collection<ShipToAddress> _shipToAddress;
        
        [XmlElement("ShipToAddress")]
        public Collection<ShipToAddress> ShipToAddress
        {
            get => _shipToAddress;
            private set => _shipToAddress = value;
        }

        [XmlIgnore()]
        public bool ShipToAddressSpecified => ShipToAddress.Count != 0;
        
        [MaxLength(41)]
        [XmlElement("PrintAs")]
        public string PrintAs { get; set; }
        
        [MaxLength(21)]
        [XmlElement("Phone")]
        public string Phone { get; set; }
        
        [MaxLength(21)]
        [XmlElement("Mobile")]
        public string Mobile { get; set; }
        
        [MaxLength(21)]
        [XmlElement("Pager")]
        public string Pager { get; set; }
        
        [MaxLength(21)]
        [XmlElement("AltPhone")]
        public string AltPhone { get; set; }
        
        [MaxLength(21)]
        [XmlElement("Fax")]
        public string Fax { get; set; }
        
        [MaxLength(1023)]
        [XmlElement("Email")]
        public string Email { get; set; }
        
        [MaxLength(1023)]
        [XmlElement("Cc")]
        public string Cc { get; set; }
        
        [MaxLength(41)]
        [XmlElement("Contact")]
        public string Contact { get; set; }
        
        [MaxLength(41)]
        [XmlElement("AltContact")]
        public string AltContact { get; set; }
        
        [XmlIgnore()]
        private Collection<AdditionalContactRef> _additionalContactRef;
        
        [XmlElement("AdditionalContactRef")]
        public Collection<AdditionalContactRef> AdditionalContactRef
        {
            get => _additionalContactRef;
            private set => _additionalContactRef = value;
        }

        [XmlIgnore()]
        public bool AdditionalContactRefSpecified => AdditionalContactRef.Count != 0;

        [XmlIgnore()]
        private Collection<Contacts> _contacts;
        
        [XmlElement("ContactsRet")]
        public Collection<Contacts> Contacts
        {
            get => _contacts;
            private set => _contacts = value;
        }

        [XmlIgnore()]
        public bool ContactsRetSpecified => Contacts.Count != 0;

        [XmlElement("CustomerTypeRef")]
        public CustomerTypeRef CustomerTypeRef { get; set; }
        
        [XmlElement("TermsRef")]
        public TermsRef TermsRef { get; set; }
        
        [XmlElement("SalesRepRef")]
        public SalesRepRef SalesRepRef { get; set; }
        
        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("Balance")]
        public decimal? Balance { get; set; }

        [XmlIgnore()]
        public bool BalanceSpecified => Balance.HasValue;
        
        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("TotalBalance")]
        public decimal? TotalBalance { get; set; }

        [XmlIgnore()]
        public bool TotalBalanceSpecified => TotalBalance.HasValue;
        
        [XmlElement("SalesTaxCodeRef")]
        public SalesTaxCodeRef SalesTaxCodeRef { get; set; }
        
        [XmlElement("ItemSalesTaxRef")]
        public ItemSalesTaxRef ItemSalesTaxRef { get; set; }
        
        [XmlElement("SalesTaxCountry")]
        public SalesTaxCountry? SalesTaxCountry { get; set; }

        [XmlIgnore()]
        public bool SalesTaxCountrySpecified => SalesTaxCountry.HasValue;
        
        [MaxLength(15)]
        [XmlElement("ResaleNumber")]
        public string ResaleNumber { get; set; }
        
        [MaxLength(99)]
        [XmlElement("AccountNumber")]
        public string AccountNumber { get; set; }
        
        [RegularExpression("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [XmlElement("CreditLimit")]
        public decimal? CreditLimit { get; set; }

        [XmlIgnore()]
        public bool CreditLimitSpecified => CreditLimit.HasValue;
        
        [XmlElement("PreferredPaymentMethodRef")]
        public PreferredPaymentMethodRef PreferredPaymentMethodRef { get; set; }
        
        [XmlElement("CreditCardInfo")]
        public CreditCardInfo CreditCardInfo { get; set; }
        
        [XmlElement("JobStatus")]
        public JobStatus? JobStatus { get; set; }

        [XmlIgnore()]
        public bool JobStatusSpecified => JobStatus.HasValue;
        
        [XmlElement("JobStartDate")]
        public DateTime? JobStartDate { get; set; }

        [XmlIgnore()]
        public bool JobStartDateSpecified => JobStartDate.HasValue;

        [XmlElement("JobProjectedEndDate")]
        public DateTime? JobProjectedEndDate { get; set; }

        [XmlIgnore()]
        public bool JobProjectedEndDateSpecified => JobProjectedEndDate.HasValue;

        [XmlElement("JobEndDate")]
        public DateTime? JobEndDate { get; set; }

        [XmlIgnore()]
        public bool JobEndDateSpecified => JobEndDate.HasValue;

        [MaxLength(99)]
        [XmlElement("JobDesc")]
        public string JobDesc { get; set; }
        
        [XmlElement("JobTypeRef")]
        public JobTypeRef JobTypeRef { get; set; }
        
        [MaxLength(4095)]
        [XmlElement("Notes")]
        public string Notes { get; set; }
        
        [XmlIgnore()]
        private Collection<AdditionalNotes> _additionalNotes;
        
        [XmlElement("AdditionalNotesRet")]
        public Collection<AdditionalNotes> AdditionalNotes
        {
            get => _additionalNotes;
            private set => _additionalNotes = value;
        }

        [XmlIgnore()]
        public bool AdditionalNotesRetSpecified => AdditionalNotes.Count != 0;

        [XmlElement("IsStatementWithParent")]
        internal string IsStatementWithParentString
        {
            get => IsStatementWithParent == null ? null : (IsStatementWithParent.Value ? "true" : "false");
            set => IsStatementWithParent = value == null ? null : value == "true";
        }

        [XmlIgnore()]
        public bool? IsStatementWithParent { get; set; }

        [XmlElement("DeliveryMethod")]
        public DeliveryMethod? DeliveryMethod { get; set; }

        [XmlIgnore()]
        public bool DeliveryMethodSpecified => DeliveryMethod.HasValue;

        [XmlElement("PreferredDeliveryMethod")]
        public PreferredDeliveryMethod? PreferredDeliveryMethod { get; set; }

        [XmlIgnore()]
        public bool PreferredDeliveryMethodSpecified => PreferredDeliveryMethod.HasValue;

        [XmlElement("PriceLevelRef")]
        public PriceLevelRef PriceLevelRef { get; set; }
        
        [RegularExpression("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [XmlElement("ExternalGUID")]
        public string ExternalGUID { get; set; }
        
        [MaxLength(30)]
        [XmlElement("TaxRegistrationNumber")]
        public string TaxRegistrationNumber { get; set; }
        
        [XmlElement("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }
        
        [XmlIgnore()]
        private Collection<DataExt> _dataExt;
        
        [XmlElement("DataExtRet")]
        public Collection<DataExt> DataExt
        {
            get => _dataExt;
            private set => _dataExt = value;
        }

        [XmlIgnore()]
        public bool DataExtRetSpecified => DataExt.Count != 0;

        public Customer()
        {
            _shipToAddress = new Collection<ShipToAddress>();
            _additionalContactRef = new Collection<AdditionalContactRef>();
            _contacts = new Collection<Contacts>();
            _additionalNotes = new Collection<AdditionalNotes>();
            _dataExt = new Collection<DataExt>();
        }

    }
}
