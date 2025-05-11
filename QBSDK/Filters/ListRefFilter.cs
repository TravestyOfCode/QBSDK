using QBSDK.Utilities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK;

public class ListRefFilter
{
    public List<string>? ListID { get; set; }

    public List<string>? FullName { get; set; }

    public List<string>? ListIDWithChildren { get; set; }

    public List<string>? FullNameWithChildren { get; set; }

    public ListRefFilter() { }
    public ListRefFilter(XElement element)
    {
        element.SetFromElements(ListID);
        element.SetFromElements(FullName);
        element.SetFromElements(ListIDWithChildren);
        element.SetFromElements(FullNameWithChildren);
    }

    public XElement ToXElement(string name = nameof(ListRefFilter))
    {
        return new XElement(name)
            .AddElements(ListID)
            .AddElements(FullName)
            .AddElements(ListIDWithChildren)
            .AddElements(FullNameWithChildren);
    }
}

internal static class ListRefFilterExtensions
{
    public static XElement AddElement(this XElement element, ListRefFilter? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(value.ToXElement(name));
        }
        return element;
    }
}
