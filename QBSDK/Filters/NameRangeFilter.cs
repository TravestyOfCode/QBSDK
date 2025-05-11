using QBSDK.Utilities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK;

public class NameRangeFilter
{
    public string? FromName;

    public string? ToName;

    public NameRangeFilter() { }
    public NameRangeFilter(XElement element)
    {
        element.SetFromElement(out FromName);
        element.SetFromElement(out ToName);
    }

    public XElement ToXElement(string name = nameof(NameRangeFilter))
    {
        return new XElement(name)
            .AddElement(FromName)
            .AddElement(ToName);
    }
}

internal static class NameRangeFilterExtensions
{
    public static XElement AddElement(this XElement element, NameRangeFilter? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(value.ToXElement(name));
        }
        return element;
    }
}
