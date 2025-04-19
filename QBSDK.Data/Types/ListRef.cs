using QBSDK.Data.Utilities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK.Data;

public class ListRef
{
    public string? ListID { get; set; }
    public string? FullName { get; set; }

    public ListRef() { }
    public ListRef(string? listID, string? fullName)
    {
        ListID = listID;
        FullName = fullName;
    }

    public XElement ToQBXML(QBVersion version = default!, string name = nameof(ListRef))
    {
        return new XElement(name)
            .Append(ListID)
            .Append(FullName);
    }
}

public static class ListRefExtensions
{
    public static ListRef? AsListRef(this ListRefBase? entity) => entity == null
            ? null
            : new ListRef(entity.ListID, entity.FullName);

    public static XElement Append(this XElement element, ListRef? value, [CallerArgumentExpression(nameof(value))] string name = "", QBVersion version = default!)
    {
        if (value != null)
        {
            element.Add(value.ToQBXML(version, name));
        }
        return element;
    }
    public static XElement AppendIf(this XElement element, Func<bool> predicate, ListRef? value, [CallerArgumentExpression(nameof(value))] string name = "", QBVersion version = default!)
    {
        if (predicate() && value != null)
        {
            element.Add(value.ToQBXML(version, name));
        }
        return element;
    }
}
