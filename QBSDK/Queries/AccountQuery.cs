using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class AccountQuery : ListQuery<Account>
    {
        private List<AccountType> AccountType;
        public List<AccountType> AccountTypeList { get => AccountType; set => AccountType = value; }

        public BaseRefFilter CurrencyFilter { get; set; }

        public override XElement ToQueryRq(QBCountry qbCountry = QBCountry.US)
        { 
            XElement AccountQueryRq = new XElement(nameof(AccountQueryRq));

            AccountQueryRq.Add(metaData?.ToXAttribute(nameof(metaData)));

            AccountQueryRq.Add(ActiveStatus?.ToXElement(nameof(ActiveStatus)));

            AccountQueryRq.Add(FromModifiedDate?.ToXElement(nameof(FromModifiedDate)));

            AccountQueryRq.Add(ToModifiedDate?.ToXElement(nameof(ToModifiedDate)));

            AccountQueryRq.Add(NameFilter?.ToXElement(nameof(NameFilter)));

            AccountQueryRq.Add(NameRangeFilter?.ToXElement(nameof(NameRangeFilter)));

            AccountQueryRq.Add(AccountType?.ToXElementList(nameof(AccountType)));

            AccountQueryRq.Add(CurrencyFilter?.ToXElement(nameof(CurrencyFilter)));

            IncludeRetElementList?.ForEach(IncludeRetElement => AccountQueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => AccountQueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            return AccountQueryRq;
        }

    }

    public class AccountListIDQuery : ListIDQuery<Account>
    {
        public AccountListIDQuery() : base()
        {

        }
        public AccountListIDQuery(params string[] listIDs) : base(listIDs)
        {

        }

        public override XElement ToQueryRq(QBCountry qbCountry = QBCountry.US)
        {
            XElement AccountQueryRq = new XElement(nameof(AccountQueryRq));

            ListIDList?.ForEach(ListID => AccountQueryRq.Add(ListID.ToXElement(nameof(ListID))));

            IncludeRetElementList?.ForEach(IncludeRetElement => AccountQueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => AccountQueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            return AccountQueryRq;
        }
    }

    public class AccountFullNameQuery : FullNameQuery<Account>
    {
        public AccountFullNameQuery() : base()
        {

        }

        public AccountFullNameQuery(params string[] fullNames) : base(fullNames)
        {

        }

        public override XElement ToQueryRq(QBCountry qbCountry)
        {
            XElement AccountQueryRq = new XElement(nameof(AccountQueryRq));

            FullNameList?.ForEach(FullName => AccountQueryRq.Add(FullName.ToXElement(nameof(FullName))));

            IncludeRetElementList?.ForEach(IncludeRetElement => AccountQueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => AccountQueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            return AccountQueryRq;
        }
    }
}
