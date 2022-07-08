using System.Xml.Linq;

namespace QBSDK
{
    public class CustomerQuery : ListQuery<Customer>
    {
        public int? MaxReturned { get; set; }

        public TotalBalanceFilter TotalBalance { get; set; }

        public BaseRefFilter CurrencyFilter { get; set; }

        public BaseRefChildrenFilter ClassFilter { get; set; }

        public override XElement ToQueryRq(QBVersionInfo versionInfo)
        {
            XElement QBXMLMsgsRq = new XElement(nameof(QBXMLMsgsRq));

            XElement QueryRq = new XElement(QueryType);

            QueryRq.Add(metaData.ToXAttribute(nameof(metaData)));
            
            if(MaxReturned != null)
            {
                iterator ??= Iterator.Start;
                
                QueryRq.Add(iterator.ToXAttribute(nameof(iterator)));
                QueryRq.Add(iteratorID.ToXAttribute(nameof(iteratorID)));
                QueryRq.Add(MaxReturned.ToXElement(nameof(MaxReturned)));
            }

            QueryRq.Add(ActiveStatus.ToXElement(nameof(ActiveStatus)));

            QueryRq.Add(FromModifiedDate.ToXElement(nameof(FromModifiedDate)));

            QueryRq.Add(ToModifiedDate.ToXElement(nameof(ToModifiedDate)));

            QueryRq.Add(NameFilter.ToXElement(nameof(NameFilter)));

            QueryRq.Add(NameRangeFilter.ToXElement(nameof(NameRangeFilter)));

            QueryRq.Add(TotalBalance.ToXElement(nameof(TotalBalanceFilter)));

            QueryRq.Add(CurrencyFilter.ToXElement(nameof(CurrencyFilter)));

            QueryRq.Add(ClassFilter.ToXElement(nameof(ClassFilter)));

            IncludeRetElementList?.ForEach(IncludeRetElement => QueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => QueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            QBXMLMsgsRq.Add(QueryRq);

            return QBXMLMsgsRq;
        }
    }

    public class CustomerListIDQuery : ListIDQuery<Customer>
    {

    }

    public class CustomerFullNameQuery : FullNameQuery<Customer>
    {

    }
}
