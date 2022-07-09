using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class Account : QBListObject
    {
        private readonly ListType ListDelType = ListType.Account;

        public AccountType? AccountType { get; set; }

        public SpecialAccountType? SpecialAccountType { get; set; }

        public string AccountNumber { get; set; }

        public string BankNumber { get; set; }

        public string Desc { get; set; }

        public decimal? OpenBalance { get; set; }

        public DateTime? OpenBalanceDate { get; set; }

        public decimal? Balance { get; private set; }

        public decimal? TotalBalance { get; private set; }

        public BaseRef SalesTaxCodeRef { get; set; }

        private TaxLineInfo TaxLineInfoRet;
        public TaxLineInfo TaxLineInfo
        {
            get => TaxLineInfoRet;
            set => TaxLineInfoRet = value;
        }

        public CashFlowClassification? CashFlowClassification { get; set; }

        public BaseRef CurrencyRef { get; set; }

        private List<DataExt> DataExtRet;
        public List<DataExt> DataExt
        {
            get => DataExtRet;
            set => DataExtRet = value;
        }

        public override XElement ToAddRq(QBCountry qbCountry = QBCountry.US)
        {   
            XElement AccountAdd = new XElement(nameof(AccountAdd));
            AccountAdd.Add(Name?.ToXElement(nameof(Name)));
            AccountAdd.Add(IsActive?.ToXElement(nameof(IsActive)));
            AccountAdd.Add(ParentRef?.ToXElement(nameof(ParentRef)));
            AccountAdd.Add(AccountType?.ToXElement(nameof(AccountType)));
            AccountAdd.Add(AccountNumber?.ToXElement(nameof(AccountNumber)));
            AccountAdd.Add(BankNumber?.ToXElement(nameof(BankNumber)));
            AccountAdd.Add(Desc?.ToXElement(nameof(Desc)));
            AccountAdd.Add(OpenBalance?.ToXElement(nameof(OpenBalance)));
            AccountAdd.Add(OpenBalanceDate?.ToXElement(nameof(OpenBalanceDate)));            
            if(qbCountry.HasFlag(QBCountry.CA) | qbCountry.HasFlag(QBCountry.UK))            
                AccountAdd.Add(SalesTaxCodeRef?.ToXElement(nameof(SalesTaxCodeRef)));
            if(qbCountry.HasFlag(QBCountry.US) || qbCountry.HasFlag(QBCountry.CA))            
                AccountAdd.Add(TaxLineInfo?.ToXElement(nameof(TaxLineInfo)));
            AccountAdd.Add(CurrencyRef?.ToXElement(nameof(CurrencyRef)));

            //XElement AccountAddRq = new XElement(nameof(AccountAddRq));
            //AccountAddRq.Add(AccountAdd);
            //if (versionInfo.Version.Major >= 4)
            //    AccountAddRq.Add(IncludeRetElement?.ToXElementList(nameof(IncludeRetElement)));
            
            return AccountAdd;
        }

        public override XElement ToModRq(QBCountry qbCountry = QBCountry.US)
        {            
            XElement AccountMod = new XElement(nameof(AccountMod));
            AccountMod.Add(ListID?.ToXElement(nameof(ListID)));
            AccountMod.Add(EditSequence?.ToXElement(nameof(EditSequence)));
            AccountMod.Add(Name?.ToXElement(nameof(Name)));
            AccountMod.Add(IsActive?.ToXElement(nameof(IsActive)));
            AccountMod.Add(ParentRef?.ToXElement(nameof(ParentRef)));
            AccountMod.Add(AccountType?.ToXElement(nameof(AccountType)));
            AccountMod.Add(AccountNumber?.ToXElement(nameof(AccountNumber)));
            AccountMod.Add(BankNumber?.ToXElement(nameof(BankNumber)));
            AccountMod.Add(Desc?.ToXElement(nameof(Desc)));
            AccountMod.Add(OpenBalance?.ToXElement(nameof(OpenBalance)));
            AccountMod.Add(OpenBalanceDate?.ToXElement(nameof(OpenBalanceDate)));            
            if(qbCountry.HasFlag(QBCountry.CA) || qbCountry.HasFlag(QBCountry.UK))            
                AccountMod.Add(SalesTaxCodeRef?.ToXElement(nameof(SalesTaxCodeRef)));
            if (qbCountry.HasFlag(QBCountry.CA) || qbCountry.HasFlag(QBCountry.US))
                AccountMod.Add(TaxLineInfo?.ToXElement(nameof(TaxLineInfo)));
            AccountMod.Add(CurrencyRef?.ToXElement(nameof(CurrencyRef)));

            //XElement AccountModRq = new XElement(nameof(AccountModRq));
            //AccountModRq.Add(AccountMod);
            //if (versionInfo.Version.Minor >= 4)
            //    AccountModRq.Add(IncludeRetElement?.ToXElementList(nameof(IncludeRetElement)));

            return AccountMod;
        }

        public override XElement ToDelRq(QBCountry qbCountry = QBCountry.US)
        {            
            XElement ListDelRq = new XElement(nameof(ListDelRq));
            ListDelRq.Add(ListDelType.ToXElement(nameof(ListDelType)));
            ListDelRq.Add(ListID?.ToXElement(nameof(ListID)));
            return ListDelRq;
        }

        public override void Parse(XElement ret)
        {
            if (ret.Name.LocalName != "AccountRet")
                return;

            base.Parse(ret);

            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(AccountType): AccountType = element.AsEnum<AccountType>(); break;
                    case nameof(SpecialAccountType): SpecialAccountType = element.AsEnum<SpecialAccountType>(); break;
                    case nameof(AccountNumber): AccountNumber = element.AsString(); break;
                    case nameof(BankNumber): BankNumber = element.AsString(); break;
                    case nameof(Desc): Desc = element.AsString(); break;
                    case nameof(Balance): Balance = element.AsDecimal(); break;
                    case nameof(TotalBalance): TotalBalance = element.AsDecimal(); break;
                    case nameof(TaxLineInfoRet): TaxLineInfoRet = element; break;
                    case nameof(CashFlowClassification): CashFlowClassification = element.AsEnum<CashFlowClassification>(); break;
                    case nameof(CurrencyRef): CurrencyRef = element; break;
                    case "DataExtRet":
                        if (DataExt == null)
                        {
                            DataExt = new List<DataExt>();
                        }
                        DataExt.Add(element);
                        break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(Account))
        {
            XElement result = new XElement(name);
            result.Add(ListID.ToXElement(nameof(ListID)));
            result.Add(TimeCreated.ToXElement(nameof(TimeCreated)));
            result.Add(TimeModified.ToXElement(nameof(TimeModified)));
            result.Add(EditSequence.ToXElement(nameof(EditSequence)));
            result.Add(Name.ToXElement(nameof(Name)));
            result.Add(FullName.ToXElement(nameof(FullName)));
            result.Add(IsActive.ToXElement(nameof(IsActive)));
            result.Add(ParentRef.ToXElement(nameof(ParentRef)));
            result.Add(Sublevel.ToXElement(nameof(Sublevel)));
            result.Add(AccountType.ToXElement(nameof(AccountType)));
            result.Add(SpecialAccountType.ToXElement(nameof(SpecialAccountType)));
            result.Add(AccountNumber.ToXElement(nameof(AccountNumber)));
            result.Add(BankNumber.ToXElement(nameof(BankNumber)));
            result.Add(Desc.ToXElement(nameof(Desc)));
            result.Add(Balance.ToXElement(nameof(Balance)));
            result.Add(TotalBalance.ToXElement(nameof(TotalBalance)));
            result.Add(TaxLineInfoRet.ToXElement(nameof(TaxLineInfoRet)));
            result.Add(CashFlowClassification.ToXElement(nameof(CashFlowClassification)));
            result.Add(CurrencyRef.ToXElement(nameof(CurrencyRef)));
            result.Add(DataExtRet.ToXElement(nameof(DataExtRet)));
            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();

        public static Account Create(XElement ret)
        {
            if (ret == null)
                return null;

            Account result = new Account();
            result.Parse(ret);
            return result;
        }

        public static implicit  operator Account(XElement ret) => Create(ret);
    }
}
