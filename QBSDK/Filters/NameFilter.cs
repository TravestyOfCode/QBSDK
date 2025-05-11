using QBSDK.Utilities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK;

public class NameFilter
{
    public MatchCriterion? MatchCriterion { get; set; }

    public required string Name { get; set; }

    public NameFilter() { }
    public NameFilter(XElement element)
    {
        element.SetFromElement(MatchCriterion);
        element.SetFromElement(Name);
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
