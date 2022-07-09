using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class Customer : QBListObject
    {
        private readonly ListType ListDelType = ListType.Customer;

        public BaseRef ClassRef { get; set; }

        public string CompanyName { get; set; }

        public string Salutation { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public Address BillAddress { get; set; }

        public Address ShipAddress { get; set; }

        private List<ShipToAddress> ShipToAddress;
        public List<ShipToAddress> ShipToAddressList { get => ShipToAddress; set => ShipToAddress = value; }

        public string Phone { get; set; }

        public string AltPhone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Cc { get; set; }

        public string Contact { get; set; }

        public string AltContact { get; set; }

        private List<AdditionalContact> AdditionalContactRef;
        public List<AdditionalContact> AdditionalContactList { get => AdditionalContactRef; set => AdditionalContactRef = value; }

        private List<Contacts> ContactsRet;
        public List<Contacts> ContactsList { get => ContactsRet; set => ContactsRet = value; }

        public BaseRef CustomerTypeRef { get; set; }

        public BaseRef TermsRef { get; set; }

        public BaseRef SalesRepRef { get; set; }

        public decimal? OpenBalance { get; set; }

        public DateTime? OpenBalanceDate { get; set; }

        public decimal? Balance { get; private set; }

        public decimal? TotalBalance { get; private set; }

        public BaseRef SalesTaxCodeRef { get; set; }

        public BaseRef ItemSalesTaxRef { get; set; }

        public SalesTaxCountry? SalesTaxCountry { get; set; }

        public string ResaleNumber { get; set; }

        public string AccountNumber { get; set; }

        public decimal? CreditLimit { get; set; }

        public BaseRef PreferredPaymentMethodRef { get; set; }

        public CreditCardInfo CreditCardInfo { get; set; }

        public JobStatus? JobStatus { get; set; }

        public DateTime? JobStartDate { get; set; }

        public DateTime? JobProjectedEndDate { get; set; }

        public DateTime? JobEndDate { get; set; }

        public string JobDesc { get; set; }

        public BaseRef JobTypeRef { get; set; }

        public string Notes { get; set; }

        private List<AdditionalNotes> AdditionalNotesRet;
        public List<AdditionalNotes> AdditionalNotesList { get; set; }

        public PreferredDeliveryMethod? PreferredDeliveryMethod { get; set; }

        public BaseRef PriceLevelRef { get; set; }

        // public string ExternalGUID { get; set; } // This isn't used in QB for anything
        
        public string TaxRegistrationNumber { get; set; }

        public BaseRef CurrencyRef { get; set; }

        private List<DataExt> DataExtRet;
        public List<DataExt> DataExtList { get => DataExtRet; set => DataExtRet = value; }

        public override XElement ToAddRq(QBVersionInfo versionInfo = null)
        {
            versionInfo ??= new QBVersionInfo();

            XElement CustomerAdd = new XElement(nameof(CustomerAdd));
            CustomerAdd.Add(Name?.ToXElement(nameof(Name)));
            CustomerAdd.Add(IsActive?.ToXElement(nameof(IsActive)));
            if(versionInfo.Version.Major >= 12)
                CustomerAdd.Add(ClassRef?.ToXElement(nameof(ClassRef)));
            CustomerAdd.Add(ParentRef?.ToXElement(nameof(ParentRef)));
            CustomerAdd.Add(CompanyName?.ToXElement(nameof(CompanyName)));
            CustomerAdd.Add(Salutation?.ToXElement(nameof(Salutation)));
            CustomerAdd.Add(FirstName?.ToXElement(nameof(FirstName)));
            CustomerAdd.Add(MiddleName?.ToXElement(nameof(MiddleName)));
            CustomerAdd.Add(LastName?.ToXElement(nameof(LastName)));
            if (versionInfo.Version.Major >= 12)
                CustomerAdd.Add(JobTitle?.ToXElement(nameof(JobTitle)));
            // NOTE: Can't use BillAddress?.ToXElement as some inner fields have different
            // version requirements even between Customer/Employee/Vendor addresses.
            if (BillAddress != null)
            {
                XElement BillAddressXElement = new XElement(nameof(BillAddress));
                BillAddressXElement.Add(BillAddress?.Addr1?.ToXElement(nameof(BillAddress.Addr1)));
                BillAddressXElement.Add(BillAddress?.Addr2?.ToXElement(nameof(BillAddress.Addr2)));
                BillAddressXElement.Add(BillAddress?.Addr3?.ToXElement(nameof(BillAddress.Addr3)));
                if (versionInfo.Version.Major >= 2)
                    BillAddressXElement.Add(BillAddress?.Addr4?.ToXElement(nameof(BillAddress.Addr4)));
                if (versionInfo.Version.Minor >= 6)
                    BillAddressXElement.Add(BillAddress?.Addr5?.ToXElement(nameof(BillAddress.Addr5)));
                BillAddressXElement.Add(BillAddress?.City?.ToXElement(nameof(BillAddress.City)));
                BillAddressXElement.Add(BillAddress?.State?.ToXElement(nameof(BillAddress.State)));
                BillAddressXElement.Add(BillAddress?.PostalCode?.ToXElement(nameof(BillAddress.PostalCode)));
                BillAddressXElement.Add(BillAddress?.Country?.ToXElement(nameof(BillAddress.Country)));
                if (versionInfo.Version.Major >= 6)
                    BillAddressXElement.Add(BillAddress?.Note?.ToXElement(nameof(BillAddress.Note)));
                CustomerAdd.Add(BillAddressXElement);
            }
            // NOTE: Can't use ShipAddress?.ToXElement as some inner fields have different
            // version requirements even between Customer/Employee/Vendor addresses.
            if (ShipAddress != null)
            {
                XElement ShipAddressXElement = new XElement(nameof(ShipAddress));
                ShipAddressXElement.Add(ShipAddress?.Addr1?.ToXElement(nameof(ShipAddress.Addr1)));
                ShipAddressXElement.Add(ShipAddress?.Addr2?.ToXElement(nameof(ShipAddress.Addr2)));
                ShipAddressXElement.Add(ShipAddress?.Addr3?.ToXElement(nameof(ShipAddress.Addr3)));
                if (versionInfo.Version.Major >= 2)
                    ShipAddressXElement.Add(ShipAddress?.Addr4?.ToXElement(nameof(ShipAddress.Addr4)));
                if (versionInfo.Version.Minor >= 6)
                    ShipAddressXElement.Add(ShipAddress?.Addr5?.ToXElement(nameof(ShipAddress.Addr5)));
                ShipAddressXElement.Add(ShipAddress?.City?.ToXElement(nameof(ShipAddress.City)));
                ShipAddressXElement.Add(ShipAddress?.State?.ToXElement(nameof(ShipAddress.State)));
                ShipAddressXElement.Add(ShipAddress?.PostalCode?.ToXElement(nameof(ShipAddress.PostalCode)));
                ShipAddressXElement.Add(ShipAddress?.Country?.ToXElement(nameof(ShipAddress.Country)));
                if (versionInfo.Version.Major >= 6)
                    ShipAddressXElement.Add(ShipAddress?.Note?.ToXElement(nameof(ShipAddress.Note)));
                CustomerAdd.Add(ShipAddressXElement);
            }
            // NOTE: Can't use ShipToAddress?.ToXElement as some inner fields have different
            // version requirements even between Customer/Employee/Vendor addresses.
            if(ShipToAddress != null)
            {
                foreach(var shipTo in ShipToAddress)
                {
                    XElement ShipToAddressXElement = new XElement(nameof(ShipToAddress));
                    ShipToAddressXElement.Add(shipTo?.Addr1?.ToXElement(nameof(shipTo.Addr1)));
                    ShipToAddressXElement.Add(shipTo?.Addr2?.ToXElement(nameof(shipTo.Addr2)));
                    ShipToAddressXElement.Add(shipTo?.Addr3?.ToXElement(nameof(shipTo.Addr3)));
                    if (versionInfo.Version.Major >= 2)
                        ShipToAddressXElement.Add(shipTo?.Addr4?.ToXElement(nameof(shipTo.Addr4)));
                    if (versionInfo.Version.Minor >= 6)
                        ShipToAddressXElement.Add(shipTo?.Addr5?.ToXElement(nameof(shipTo.Addr5)));
                    ShipToAddressXElement.Add(shipTo?.City?.ToXElement(nameof(shipTo.City)));
                    ShipToAddressXElement.Add(shipTo?.State?.ToXElement(nameof(shipTo.State)));
                    ShipToAddressXElement.Add(shipTo?.PostalCode?.ToXElement(nameof(shipTo.PostalCode)));
                    ShipToAddressXElement.Add(shipTo?.Country?.ToXElement(nameof(shipTo.Country)));
                    if (versionInfo.Version.Major >= 6)
                        ShipToAddressXElement.Add(shipTo?.Note?.ToXElement(nameof(shipTo.Note)));
                    CustomerAdd.Add(ShipToAddressXElement);
                }
            }
            CustomerAdd.Add(Phone?.ToXElement(nameof(Phone)));
            CustomerAdd.Add(AltPhone?.ToXElement(nameof(AltPhone)));
            CustomerAdd.Add(Fax?.ToXElement(nameof(Fax)));
            CustomerAdd.Add(Email?.ToXElement(nameof(Email)));
            if(versionInfo.Version.Major >= 12)
                CustomerAdd.Add(Cc?.ToXElement(nameof(Cc)));
            CustomerAdd.Add(Contact?.ToXElement(nameof(Contact)));
            CustomerAdd.Add(AltContact?.ToXElement(nameof(AltContact)));
            if (versionInfo.Version.Major >= 12)
            {
                CustomerAdd.Add(AdditionalContactRef?.ToXElement(nameof(AdditionalContactRef)));
                CustomerAdd.Add(ContactsRet?.ToXElement(nameof(Contacts)));
            }
            CustomerAdd.Add(CustomerTypeRef?.ToXElement(nameof(CustomerTypeRef)));
            CustomerAdd.Add(TermsRef?.ToXElement(nameof(TermsRef)));
            CustomerAdd.Add(SalesRepRef?.ToXElement(nameof(SalesRepRef)));
            CustomerAdd.Add(OpenBalance?.ToXElement(nameof(OpenBalance)));
            CustomerAdd.Add(OpenBalanceDate?.ToXElement(nameof(OpenBalanceDate)));
            CustomerAdd.Add(SalesTaxCodeRef?.ToXElement(nameof(SalesTaxCodeRef)));
            if(versionInfo.CountryCode == "US")
                CustomerAdd.Add(ItemSalesTaxRef?.ToXElement(nameof(ItemSalesTaxRef)));
            if(versionInfo.Version.Major >= 6 && "CA|UK".Contains(versionInfo.CountryCode))
                CustomerAdd.Add(SalesTaxCountry?.ToXElement(nameof(SalesTaxCountry)));
            CustomerAdd.Add(ResaleNumber?.ToXElement(nameof(ResaleNumber)));
            CustomerAdd.Add(AccountNumber?.ToXElement(nameof(AccountNumber)));
            CustomerAdd.Add(CreditLimit?.ToXElement(nameof(CreditLimit)));
            if (versionInfo.Version.Major >= 3)
            {
                CustomerAdd.Add(PreferredPaymentMethodRef?.ToXElement(nameof(PreferredPaymentMethodRef)));
                CustomerAdd.Add(CreditCardInfo?.ToXElement(nameof(CreditCardInfo)));
            }
            CustomerAdd.Add(JobStatus?.ToXElement(nameof(JobStatus)));
            CustomerAdd.Add(JobStartDate?.ToXElement(nameof(JobStartDate)));
            CustomerAdd.Add(JobProjectedEndDate?.ToXElement(nameof(JobProjectedEndDate)));
            CustomerAdd.Add(JobEndDate?.ToXElement(nameof(JobEndDate)));
            CustomerAdd.Add(JobDesc?.ToXElement(nameof(JobDesc)));
            CustomerAdd.Add(JobTypeRef?.ToXElement(nameof(JobTypeRef)));
            if(versionInfo.Version.Major >= 3)
                CustomerAdd.Add(Notes?.ToXElement(nameof(Notes)));
            if (versionInfo.Version.Major >= 12)
            {
                CustomerAdd.Add(AdditionalNotesRet?.ToXElement(nameof(AdditionalNotes)));
                CustomerAdd.Add(PreferredDeliveryMethod?.ToXElement(nameof(PreferredDeliveryMethod)));
            }
            if(versionInfo.Version.Major >= 4)
                CustomerAdd.Add(PriceLevelRef?.ToXElement(nameof(PriceLevelRef)));
            //CustomerAdd.Add(ExternalGUID?.ToXElement(nameof(ExternalGUID)));
            if (versionInfo.Version.Major >= 8)
            {
                CustomerAdd.Add(TaxRegistrationNumber?.ToXElement(nameof(TaxRegistrationNumber)));
                CustomerAdd.Add(CurrencyRef?.ToXElement(nameof(CurrencyRef)));
            }

            //XElement CustomerAddRq = new XElement(nameof(CustomerAddRq));
            //CustomerAddRq.Add(CustomerAdd);
            //if (versionInfo.Version.Major >= 4)
            //    CustomerAddRq.Add(IncludeRetElement?.ToXElementList(nameof(IncludeRetElement)));
            
            return CustomerAdd;
        }

        public override XElement ToModRq(QBVersionInfo versionInfo = null)
        {
            throw new NotImplementedException();
        }

        public override XElement ToDelRq(QBVersionInfo versionInfo = null)
        {
            throw new NotImplementedException();
        }

        public new void Parse(XElement ret)
        {
            if (ret == null)
                return;

            base.Parse(ret);

            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(ClassRef): ClassRef = element; break;
                    case nameof(CompanyName): CompanyName = element.AsString(); break;
                    case nameof(Salutation): Salutation = element.AsString(); break;
                    case nameof(FirstName): FirstName = element.AsString(); break;
                    case nameof(MiddleName): MiddleName = element.AsString(); break;
                    case nameof(LastName): LastName = element.AsString(); break;
                    case nameof(JobTitle): JobTitle = element.AsString(); break;
                    case nameof(BillAddress): BillAddress = element; break;
                    case nameof(ShipAddress): ShipAddress = element; break;
                    case nameof(ShipToAddress):
                        ShipToAddress ??= new List<ShipToAddress>();
                        ShipToAddressList.Add(element);
                        break;
                    case nameof(Phone): Phone = element.AsString(); break;
                    case nameof(AltPhone): AltPhone = element.AsString(); break;
                    case nameof(Fax): Fax = element.AsString(); break;
                    case nameof(Email): Email = element.AsString(); break;
                    case nameof(Cc): Cc = element.AsString(); break;
                    case nameof(Contact): Contact = element.AsString(); break;
                    case nameof(AltContact): AltContact = element.AsString(); break;
                    case nameof(AdditionalContactRef):
                        AdditionalContactRef ??= new List<AdditionalContact>();
                        AdditionalContactRef.Add(element);
                        break;
                    case nameof(ContactsRet):
                        ContactsRet ??= new List<Contacts>();
                        ContactsRet.Add(element);
                        break;
                    case nameof(CustomerTypeRef): CustomerTypeRef = element; break;
                    case nameof(TermsRef): TermsRef = element; break;
                    case nameof(SalesRepRef): SalesRepRef = element; break;
                    case nameof(Balance): Balance = element.AsDecimal(); break;
                    case nameof(TotalBalance): TotalBalance = element.AsDecimal(); break;
                    case nameof(SalesTaxCodeRef): SalesTaxCodeRef = element; break;
                    case nameof(ItemSalesTaxRef): ItemSalesTaxRef = element; break;
                    case nameof(SalesTaxCountry): SalesTaxCountry = element.AsEnum<SalesTaxCountry>(); break;
                    case nameof(ResaleNumber): ResaleNumber = element.AsString(); break;
                    case nameof(AccountNumber): AccountNumber = element.AsString(); break;
                    case nameof(CreditLimit): CreditLimit = element.AsDecimal(); break;
                    case nameof(PreferredPaymentMethodRef): PreferredPaymentMethodRef = element; break;
                    case nameof(CreditCardInfo): CreditCardInfo = element; break;
                    case nameof(JobStatus): JobStatus = element.AsEnum<JobStatus>(); break;
                    case nameof(JobStartDate): JobStartDate = element.AsDateTime(); break;
                    case nameof(JobProjectedEndDate): JobProjectedEndDate = element.AsDateTime(); break;
                    case nameof(JobEndDate): JobEndDate = element.AsDateTime(); break;
                    case nameof(JobDesc): JobDesc = element.AsString(); break;
                    case nameof(JobTypeRef): JobTypeRef = element; break;
                    case nameof(Notes): Notes = element.AsString(); break;
                    case nameof(AdditionalNotesRet):
                        AdditionalNotesRet ??= new List<AdditionalNotes>();
                        AdditionalNotesRet.Add(element);
                        break;
                    case nameof(PreferredDeliveryMethod): PreferredDeliveryMethod = element.AsEnum<PreferredDeliveryMethod>(); break;
                    case nameof(PriceLevelRef): PriceLevelRef = element; break;
                    case nameof(TaxRegistrationNumber): TaxRegistrationNumber = element.AsString(); break;
                    case nameof(CurrencyRef): CurrencyRef = element; break;
                    case nameof(DataExtRet):
                        DataExtRet ??= new List<DataExt>();
                        DataExtRet.Add(element);
                        break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(Customer))
        {
            XElement result = new XElement(name);
            result.Add(ListID?.ToXElement(nameof(ListID)));
            result.Add(TimeCreated?.ToXElement(nameof(TimeCreated)));
            result.Add(TimeModified?.ToXElement(nameof(TimeModified)));
            result.Add(EditSequence?.ToXElement(nameof(EditSequence)));
            result.Add(Name?.ToXElement(nameof(Name)));
            result.Add(FullName?.ToXElement(nameof(FullName)));
            result.Add(IsActive?.ToXElement(nameof(IsActive)));
            result.Add(ClassRef?.ToXElement(nameof(ClassRef)));
            result.Add(ParentRef?.ToXElement(nameof(ParentRef)));
            result.Add(CompanyName?.ToXElement(nameof(CompanyName)));
            result.Add(Salutation?.ToXElement(nameof(Salutation)));
            result.Add(FirstName?.ToXElement(nameof(FirstName)));
            result.Add(MiddleName?.ToXElement(nameof(MiddleName)));
            result.Add(LastName?.ToXElement(nameof(LastName)));
            result.Add(JobTitle?.ToXElement(nameof(JobTitle)));
            result.Add(BillAddress?.ToXElement(nameof(BillAddress)));
            result.Add(ShipAddress?.ToXElement(nameof(ShipAddress)));
            result.Add(ShipToAddress?.ToXElement(nameof(ShipToAddress)));
            result.Add(Phone?.ToXElement(nameof(Phone)));
            result.Add(AltPhone?.ToXElement(nameof(AltPhone)));
            result.Add(Fax?.ToXElement(nameof(Fax)));
            result.Add(Email?.ToXElement(nameof(Email)));
            result.Add(Cc?.ToXElement(nameof(Cc)));
            result.Add(Contact?.ToXElement(nameof(Contact)));
            result.Add(AltContact?.ToXElement(nameof(AltContact)));
            result.Add(AdditionalContactRef?.ToXElement(nameof(AdditionalContactRef)));
            result.Add(ContactsRet?.ToXElement(nameof(ContactsRet)));
            result.Add(CustomerTypeRef?.ToXElement(nameof(CustomerTypeRef)));
            result.Add(TermsRef?.ToXElement(nameof(TermsRef)));
            result.Add(SalesRepRef?.ToXElement(nameof(SalesRepRef)));
            result.Add(Balance?.ToXElement(nameof(Balance)));
            result.Add(TotalBalance?.ToXElement(nameof(TotalBalance)));
            result.Add(SalesTaxCodeRef?.ToXElement(nameof(SalesTaxCodeRef)));
            result.Add(ItemSalesTaxRef?.ToXElement(nameof(ItemSalesTaxRef)));
            result.Add(ResaleNumber?.ToXElement(nameof(ResaleNumber)));
            result.Add(AccountNumber?.ToXElement(nameof(AccountNumber)));
            result.Add(CreditLimit?.ToXElement(nameof(CreditLimit)));
            result.Add(PreferredPaymentMethodRef?.ToXElement(nameof(PreferredPaymentMethodRef)));
            result.Add(CreditCardInfo?.ToXElement(nameof(CreditCardInfo)));
            result.Add(JobStatus?.ToXElement(nameof(JobStatus)));
            result.Add(JobStartDate?.ToXElement(nameof(JobStartDate)));
            result.Add(JobProjectedEndDate?.ToXElement(nameof(JobProjectedEndDate)));
            result.Add(JobEndDate?.ToXElement(nameof(JobEndDate)));
            result.Add(JobDesc?.ToXElement(nameof(JobDesc)));
            result.Add(JobTypeRef?.ToXElement(nameof(JobTypeRef)));
            result.Add(Notes?.ToXElement(nameof(Notes)));
            result.Add(AdditionalNotesRet?.ToXElement(nameof(AdditionalNotesRet)));
            result.Add(PreferredDeliveryMethod?.ToXElement(nameof(PreferredDeliveryMethod)));
            result.Add(PriceLevelRef?.ToXElement(nameof(PriceLevelRef)));
            //result.Add(ExternalGUID?.ToXElement(nameof(ExternalGUID)));
            result.Add(CurrencyRef?.ToXElement(nameof(CurrencyRef)));
            result.Add(DataExtRet?.ToXElement(nameof(DataExtRet)));
            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();

        public static Customer Create(XElement ret)
        {
            if (ret == null)
                return null;

            Customer result = new Customer();
            result.Parse(ret);
            return result;
        }

        public static implicit operator Customer(XElement ret) => Create(ret);
    }
}
