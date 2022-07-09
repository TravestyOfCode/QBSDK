using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class Customer : QBListObject
    {
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

        public decimal? Balance { get; private set; }

        public decimal? TotalBalance { get; private set; }

        public BaseRef SalesTaxCodeRef { get; set; }

        public BaseRef ItemSalesTaxRef { get; set; }

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

        private List<AdditionalNote> AdditionalNotesRet;
        public List<AdditionalNote> AdditionalNotesList { get; set; }

        public PreferredDeliveryMethod? PreferredDeliveryMethod { get; set; }

        public BaseRef PriceLevelRef { get; set; }

        // public string ExternalGUID { get; set; } // This isn't used in QB for anything

        public BaseRef CurrencyRef { get; set; }

        private List<DataExt> DataExtRet;
        public List<DataExt> DataExtList { get => DataExtRet; set => DataExtRet = value; }

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
                        AdditionalNotesRet ??= new List<AdditionalNote>();
                        AdditionalNotesRet.Add(element);
                        break;
                    case nameof(PreferredDeliveryMethod): PreferredDeliveryMethod = element.AsEnum<PreferredDeliveryMethod>(); break;
                    case nameof(PriceLevelRef): PriceLevelRef = element; break;
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
