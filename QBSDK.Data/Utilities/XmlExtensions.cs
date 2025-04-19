using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK.Data.Utilities;

public static class XmlExtensions
{
    public static XElement Append(this XElement element, string? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.ToString()));
        }
        return element;
    }
    public static XElement Append(this XElement element, bool? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.Value ? "true" : "false"));
        }
        return element;
    }
    public static XElement Append(this XElement element, int? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.ToString()));
        }
        return element;
    }
    public static XElement Append(this XElement element, decimal? value, int decimalPlaces = 2, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.Value.ToString($"F{decimalPlaces}")));
        }
        return element;
    }
    public static XElement Append(this XElement element, Enum? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.ToString()));
        }
        return element;
    }
    public static XElement Append(this XElement element, DateOnly? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.Value.ToString("yyyy-MM-dd")));
        }
        return element;
    }

    public static XElement AppendIf(this XElement element, Func<bool> predicate, int? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (predicate() && value != null)
        {
            element.Add(new XElement(name, value.ToString()));
        }
        return element;
    }
}
