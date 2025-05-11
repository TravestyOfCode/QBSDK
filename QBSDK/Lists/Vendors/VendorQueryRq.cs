using QBSDK.Utilities;
using System.Xml.Linq;

namespace QBSDK;

public class VendorQueryRq : QBRequest<List<Vendor>>
{
    public List<string>? ListID { get; set; }

    public List<string>? FullName { get; set; }

    public ActiveStatus? ActiveStatus { get; set; }

    public DateTime? FromModifiedDate { get; set; }

    public DateTime? ToModifiedDate { get; set; }

    public NameFilter? NameFilter { get; set; }

    public NameRangeFilter? NameRangeFilter { get; set; }

    public AmountFilter? TotalBalanceFilter { get; set; }

    public ListRefFilter? CurrencyFilter { get; set; }

    public ListRefFilter? ClassFilter { get; set; }

    public List<string>? IncludeRetElement { get; set; }

    public List<string>? OwnerID { get; set; }

    public new XElement ToXElement(string name = nameof(VendorQueryRq))
    {
        return base.ToXElement(name)
            .AddElements(ListID)
            .AddElements(FullName)
            .AddElement(MaxReturned)
            .AddElement(ActiveStatus)
            .AddElement(FromModifiedDate)
            .AddElement(ToModifiedDate)
            .AddElement(NameFilter)
            .AddElement(NameRangeFilter)
            .AddElement(TotalBalanceFilter)
            .AddElement(CurrencyFilter)
            .AddElement(ClassFilter)
            .AddElements(IncludeRetElement)
            .AddElements(OwnerID);
    }

    public new void ParseResponse(XDocument doc)
    {
        base.ParseResponse(doc);

        if (statusCode == 0 && Response != null)
        {
            Results = [.. Response.Elements("VendorRet").Select(v => new Vendor(v))];
        }
    }
}
