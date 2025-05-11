using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK.Utilities;

public static class XElementExtensions
{
    public static XElement AddElement(this XElement element, string? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name), value);
        }
        return element;
    }
    public static XElement AddElement<T>(this XElement element, T? value, [CallerArgumentExpression(nameof(value))] string name = "") where T : struct, Enum
    {
        if (value != null)
        {
            element.Add(new XElement(name), value.ToString());
        }
        return element;
    }
    public static XElement AddElement(this XElement element, DateTime? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.Value.ToString("yyyy-MM-ddTHH:mm:ss")));
        }
        return element;
    }
    public static XElement AddElement(this XElement element, decimal? value, int decimalPlaces = 2, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        if (value != null)
        {
            element.Add(new XElement(name, value.Value.ToString($"F{decimalPlaces}")));
        }
        return element;
    }
    public static XElement AddElements(this XElement element, IEnumerable<string>? values, [CallerArgumentExpression(nameof(values))] string name = "")
    {
        if (values != null)
        {
            element.Add(values.Select(e => new XElement(name, e)));
        }
        return element;
    }

    public static void SetFromElement(this XElement? element, out string? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = element?.Element(name)?.Value;
    }
    public static void SetFromElement<T>(this XElement? element, out T? value, [CallerArgumentExpression(nameof(value))] string name = "") where T : struct, Enum
    {
        value = Enum.TryParse(typeof(T), element?.Element(name)?.Value, out var result) ? (T)result : null;
    }
    public static void SetFromElement(this XElement? element, out decimal? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = decimal.TryParse(element?.Element(name)?.Value, out var result) ? result : null;
    }
    public static void SetFromElement(this XElement? element, out decimal value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = decimal.TryParse(element?.Element(name)?.Value, out var result) ? result : 0;
    }
    public static void SetFromElement(this XElement? element, out DateTime? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = DateTime.TryParse(element?.Element(name)?.Value, out var result) ? result : null;
    }
    public static void SetFromElement(this XElement? element, out bool? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = element?.Element(name)?.Value switch
        {
            "true" => true,
            "false" => false,
            _ => null
        };
    }
    public static void SetFromElements(this XElement? element, out List<string>? values, [CallerArgumentExpression(nameof(values))] string name = "")
    {
        values = element?.Elements(name)?.Select(e => e.Value).ToList();
    }
}
