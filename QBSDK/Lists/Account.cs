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

        public TaxLineInfo? TaxLineInfo { get; set; }

        public CashFlowClassification? CashFlowClassification { get; set; }

        public BaseRef CurrencyRef { get; set; }

        public List<DataExt> DataExt { get; set; }

        public override XElement ToAddRq(QBVersionInfo versionInfo = null)
        {
            versionInfo ??= new QBVersionInfo();

            XElement AccountAddRq = base.ToAddRq(versionInfo);

            AccountAddRq.Name = nameof(AccountAddRq);
            AccountAddRq.Add(AccountType?.ToXElement(nameof(AccountType)));
            AccountAddRq.Add(AccountNumber?.ToXElement(nameof(AccountNumber)));
            AccountAddRq.Add(BankNumber?.ToXElement(nameof(BankNumber)));
            AccountAddRq.Add(Desc?.ToXElement(nameof(Desc)));
            AccountAddRq.Add(OpenBalance?.ToXElement(nameof(OpenBalance)));
            AccountAddRq.Add(OpenBalanceDate?.ToXElement(nameof(OpenBalanceDate)));
            if (versionInfo.Version.Major >= 6 && (versionInfo.CountryCode == "CA" || versionInfo.CountryCode == "UK"))
                AccountAddRq.Add(SalesTaxCodeRef?.ToXElement(nameof(SalesTaxCodeRef)));
            if (versionInfo.Version.Major >= 7 && (versionInfo.CountryCode == "US" || versionInfo.CountryCode == "CA"))
                AccountAddRq.Add(TaxLineInfo?.ToXElement(nameof(TaxLineInfo)));
            if (versionInfo.Version.Major >= 8)
                AccountAddRq.Add(CurrencyRef?.ToXElement(nameof(CurrencyRef)));

            return AccountAddRq;
        }

        public override XElement ToModRq(QBVersionInfo versionInfo = null)
        {
            versionInfo ??= new QBVersionInfo();

            XElement AccountModRq = base.ToModRq(versionInfo);

            AccountModRq.Name = nameof(AccountModRq);
            AccountModRq.Add(AccountType?.ToXElement(nameof(AccountType)));
            AccountModRq.Add(AccountNumber?.ToXElement(nameof(AccountNumber)));
            AccountModRq.Add(BankNumber?.ToXElement(nameof(BankNumber)));
            AccountModRq.Add(Desc?.ToXElement(nameof(Desc)));
            if (versionInfo.Version.Major >= 6 && (versionInfo.CountryCode == "CA" || versionInfo.CountryCode == "UK"))
                AccountModRq.Add(SalesTaxCodeRef?.ToXElement(nameof(SalesTaxCodeRef)));
            if (versionInfo.Version.Major >= 7 && (versionInfo.CountryCode == "US" || versionInfo.CountryCode == "CA"))
                AccountModRq.Add(TaxLineInfo?.ToXElement(nameof(TaxLineInfo)));
            if (versionInfo.Version.Major >= 8)
                AccountModRq.Add(CurrencyRef?.ToXElement(nameof(CurrencyRef)));

            return AccountModRq;
        }

        public override XElement ToDelRq(QBVersionInfo versionInfo = null)
        {
            versionInfo ??= new QBVersionInfo();

            XElement ListDelRq = base.ToDelRq(versionInfo);
            ListDelRq.Name = nameof(ListDelRq);
            ListDelRq.AddFirst(ListDelType.ToXElement(nameof(ListDelType)));

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
                    case "TaxLineInfoRet": TaxLineInfo = element.AsTaxLineInfo(); break;
                    case nameof(CashFlowClassification): CashFlowClassification = element.AsEnum<CashFlowClassification>(); break;
                    case nameof(CurrencyRef): CurrencyRef = element.AsBaseRef(); break;
                    case "DataExtRet":
                        if (DataExt == null)
                        {
                            DataExt = new List<DataExt>();
                        }
                        DataExt.Add(element.AsDataExt());
                        break;
                }
            }
        }

        public override string ToString()
        {
            return AccountNumber == null ? FullName : $"{AccountNumber} - {FullName}";
        }
    }
}
