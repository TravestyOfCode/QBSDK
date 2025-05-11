using QBSDK.Utilities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK;

public class AmountFilter
{
    public Operator? Operator { get; set; }

    public decimal Amount { get; set; }

    public AmountFilter() { }
    public AmountFilter(XElement element)
    {
        element.SetFromElement(Operator);
        element.SetFromElement(Amount);
    }

    public XElement ToXElement(string name = nameof(AmountFilter))
    {
        return new XElement(name)
            .AddElement(Operator)
            .AddElement(Amount);
    }
}

internal static class AmountFilterExtensions
{
    public static XElement AddElement(this XElement element, AmountFilter? value, [CallerArgumentExpression(nameof(value))] string name = nameof(AmountFilter))
    {
        if (value != null)
        {
            element.Add(value.ToXElement(name));
        }
        return element;
    }
}
