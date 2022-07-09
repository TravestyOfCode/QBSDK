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
            XElement QBXMLMsgsRq = new XElement(nameof(QBXMLMsgsRq));

            XElement QueryRq = new XElement(QueryType);

            QueryRq.Add(metaData.ToXAttribute(nameof(metaData)));

            QueryRq.Add(ActiveStatus.ToXElement(nameof(ActiveStatus)));

            QueryRq.Add(FromModifiedDate.ToXElement(nameof(FromModifiedDate)));

            QueryRq.Add(ToModifiedDate.ToXElement(nameof(ToModifiedDate)));

            QueryRq.Add(NameFilter.ToXElement(nameof(NameFilter)));

            QueryRq.Add(NameRangeFilter.ToXElement(nameof(NameRangeFilter)));

            QueryRq.Add(AccountType.ToXElementList(nameof(AccountType)));

            QueryRq.Add(CurrencyFilter.ToXElement(nameof(CurrencyFilter)));

            IncludeRetElementList?.ForEach(IncludeRetElement => QueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => QueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            QBXMLMsgsRq.Add(QueryRq);

            return QBXMLMsgsRq;
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
    }

    public class AccountFullNameQuery : FullNameQuery<Account>
    {
        public AccountFullNameQuery() : base()
        {

        }

        public AccountFullNameQuery(params string[] fullNames) : base(fullNames)
        {

        }
    }
}
