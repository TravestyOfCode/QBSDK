using System.Xml.Linq;

namespace QBSDK
{
    public class CustomerQuery : ListQuery<Customer>
    {
        public int? MaxReturned { get; set; }

        public TotalBalanceFilter TotalBalance { get; set; }

        public BaseRefFilter CurrencyFilter { get; set; }

        public BaseRefChildrenFilter ClassFilter { get; set; }

        public override XElement ToQueryRq(QBCountry qbCountry = QBCountry.US)
        { 
            XElement CustomerQueryRq = new XElement(nameof(CustomerQueryRq));

            CustomerQueryRq.Add(metaData.ToXAttribute(nameof(metaData)));
            
            if(MaxReturned != null)
            {
                iterator ??= Iterator.Start;
                
                CustomerQueryRq.Add(iterator?.ToXAttribute(nameof(iterator)));
                CustomerQueryRq.Add(iteratorID?.ToXAttribute(nameof(iteratorID)));
                CustomerQueryRq.Add(MaxReturned?.ToXElement(nameof(MaxReturned)));
            }

            CustomerQueryRq.Add(ActiveStatus?.ToXElement(nameof(ActiveStatus)));

            CustomerQueryRq.Add(FromModifiedDate?.ToXElement(nameof(FromModifiedDate)));

            CustomerQueryRq.Add(ToModifiedDate?.ToXElement(nameof(ToModifiedDate)));

            CustomerQueryRq.Add(NameFilter?.ToXElement(nameof(NameFilter)));

            CustomerQueryRq.Add(NameRangeFilter?.ToXElement(nameof(NameRangeFilter)));

            CustomerQueryRq.Add(TotalBalance?.ToXElement(nameof(TotalBalanceFilter)));

            CustomerQueryRq.Add(CurrencyFilter?.ToXElement(nameof(CurrencyFilter)));

            CustomerQueryRq.Add(ClassFilter?.ToXElement(nameof(ClassFilter)));

            IncludeRetElementList?.ForEach(IncludeRetElement => CustomerQueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => CustomerQueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            return CustomerQueryRq;
        }
    }

    public class CustomerListIDQuery : ListIDQuery<Customer>
    {
        public CustomerListIDQuery() : base()
        {

        }
        public CustomerListIDQuery(params string[] listIDs) : base(listIDs)
        {

        }

        public override XElement ToQueryRq(QBCountry qbCountry)
        {
            XElement CustomerQueryRq = new XElement(nameof(CustomerQueryRq));

            ListIDList?.ForEach(ListID => CustomerQueryRq.Add(ListID.ToXElement(nameof(ListID))));

            IncludeRetElementList?.ForEach(IncludeRetElement => CustomerQueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => CustomerQueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            return CustomerQueryRq;
        }
    }

    public class CustomerFullNameQuery : FullNameQuery<Customer>
    {
        public CustomerFullNameQuery(): base()
        {

        }
        public CustomerFullNameQuery(params string[] fullNames) : base(fullNames)
        {

        }

        public override XElement ToQueryRq(QBCountry qbCountry)
        {
            XElement CustomerQueryRq = new XElement(nameof(CustomerQueryRq));

            FullNameList?.ForEach(FullName => CustomerQueryRq.Add(FullName.ToXElement(nameof(FullName))));

            IncludeRetElementList?.ForEach(IncludeRetElement => CustomerQueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => CustomerQueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            return CustomerQueryRq;
        }
    }
}
