using QBSDK.Utilities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK;

public class NameFilter
{
    public MatchCriterion? MatchCriterion;

    public required string Name;

    public NameFilter() { }
    public NameFilter(XElement element)
    {
        element.SetFromElement(out MatchCriterion);
        element.SetFromElement(out Name!);
    }

    public XElement ToXElement(string name = nameof(NameFilter))
    {
        return new XElement(name)
            .AddElement(MatchCriterion)
            .AddElement(Name);
    }
}

internal static class NameFilterExtensions
{
    public static XElement AddElement(this XElement element, NameFilter? value, [CallerArgumentExpression(nameof(value))] string name = nameof(NameFilter))
    {
        if (value != null)
        {
            element.Add(value.ToXElement(name));
        }
        return element;
    }
}
