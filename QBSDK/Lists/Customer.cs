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

        private List<DataExt> DataExt;
        public List<DataExt> DataExtList { get => DataExt; set => DataExt = value; }

        public new void Parse(XElement ret)
        {
            if (ret == null)
                return;

            base.Parse(ret);

            foreach(var element in ret.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(ClassRef): ClassRef = element.AsBaseRef(); break;
                    case nameof(CompanyName): CompanyName = element.AsString(); break;
                    case nameof(Salutation): Salutation = element.AsString(); break;
                    case nameof(FirstName): FirstName = element.AsString(); break;
                    case nameof(MiddleName): MiddleName = element.AsString(); break;
                    case nameof(LastName): LastName = element.AsString(); break;
                    case nameof(JobTitle): JobTitle = element.AsString(); break;
                    case nameof(BillAddress): BillAddress = element.AsAddress(); break;
                    case nameof(ShipAddress): ShipAddress = element.AsAddress(); break;
                    case nameof(ShipToAddress):
                        ShipToAddress ??= new List<ShipToAddress>();
                        ShipToAddressList.Add(element.AsShipToAddress());
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
                        AdditionalContactRef.Add(element.AsAdditionalContact());
                        break;
                    case nameof(ContactsRet):
                        ContactsRet ??= new List<Contacts>();
                        ContactsRet.Add(element.AsContacts());
                        break;
                    case nameof(CustomerTypeRef): CustomerTypeRef = element.AsBaseRef(); break;
                    case nameof(TermsRef): TermsRef = element.AsBaseRef(); break;
                    case nameof(SalesRepRef): SalesRepRef = element.AsBaseRef(); break;
                    case nameof(Balance): Balance = element.AsDecimal(); break;
                    case nameof(TotalBalance): TotalBalance = element.AsDecimal(); break;
                    case nameof(SalesTaxCodeRef): SalesTaxCodeRef = element.AsBaseRef(); break;
                    case nameof(ItemSalesTaxRef): ItemSalesTaxRef = element.AsBaseRef(); break;
                    case nameof(ResaleNumber): ResaleNumber = element.AsString(); break;
                    case nameof(AccountNumber): AccountNumber = element.AsString(); break;
                    case nameof(CreditLimit): CreditLimit = element.AsDecimal(); break;
                    case nameof(PreferredPaymentMethodRef): PreferredPaymentMethodRef = element.AsBaseRef(); break;
                    case nameof(CreditCardInfo): CreditCardInfo = element.AsCreditCardInfo(); break;
                    case nameof(JobStatus): JobStatus = element.AsEnum<JobStatus>(); break;
                    case nameof(JobStartDate): JobStartDate = element.AsDateTime(); break;
                    case nameof(JobProjectedEndDate): JobProjectedEndDate = element.AsDateTime(); break;
                    case nameof(JobEndDate): JobEndDate = element.AsDateTime(); break;
                    case nameof(JobDesc): JobDesc = element.AsString(); break;
                    case nameof(JobTypeRef): JobTypeRef = element.AsBaseRef(); break;
                    case nameof(Notes): Notes = element.AsString(); break;
                    case nameof(AdditionalNotesRet):
                        AdditionalNotesRet ??= new List<AdditionalNote>();
                        AdditionalNotesRet.Add(element.AsAdditionalNote());
                        break;
                    case nameof(PreferredDeliveryMethod): PreferredDeliveryMethod = element.AsEnum<PreferredDeliveryMethod>(); break;
                    case nameof(PriceLevelRef): PriceLevelRef = element.AsBaseRef(); break;
                    case nameof(CurrencyRef): CurrencyRef = element.AsBaseRef(); break;
                    case nameof(DataExt):
                        DataExt ??= new List<DataExt>();
                        DataExt.Add(element.AsDataExt());
                        break;
                }
            }
        }

        public static Customer Create(XElement ret)
        {
            if (ret == null)
                return null;

            Customer result = new Customer();
            result.Parse(ret);
            return result;
        }
    }

    public static class CustomerExtensions
    {
        public static Customer AsCustomer(this XElement ret) => Customer.Create(ret);
    }
}
