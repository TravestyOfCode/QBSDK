using QBSDK.Data.Utilities;
using System.Xml.Linq;

namespace QBSDK.Data;

// The QBSDK uses ListDel for all lists. This is just a wrapper to keep the
// naming convention.
public class AccountDel
{
    public int Id { get; set; }
    public int? StatusCode { get; set; }
    public string? StatusSeverity { get; set; }
    public string? StatusMessage { get; set; }

    public ListDelType ListDelType { get; } = ListDelType.Account;
    public required string ListID { get; set; }

    public XElement ToQBXML(QBVersion version = default, string name = "ListDelRq")
    {
        return new XElement(name)
            .Append(ListDelType)
            .Append(ListID);
    }
}

public static class AccountDelExtensions
{
    public static AccountDel AsDel(this Account entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        ArgumentNullException.ThrowIfNull(entity.ListID);

        return new AccountDel()
        {
            ListID = entity.ListID
        };
    }
}
