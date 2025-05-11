using QBSDK.Utilities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK;

public class ListRefFilter
{
    public List<string>? ListID;

    public List<string>? FullName;

    public List<string>? ListIDWithChildren;

    public List<string>? FullNameWithChildren;

    public ListRefFilter() { }
    public ListRefFilter(XElement element)
    {
        element.SetFromElements(out ListID);
        element.SetFromElements(out FullName);
        element.SetFromElements(out ListIDWithChildren);
        element.SetFromElements(out FullNameWithChildren);
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
