using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QBSDK.Utilities;

internal static class XAttributeExtensions
{
    public static void SetFromAttribute(this XElement? element, out long? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = long.TryParse(element?.Attribute(name)?.Value, out var result) ? result : null;
    }
    public static void SetFromAttribute(this XElement? element, out int? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = int.TryParse(element?.Attribute(name)?.Value, out var result) ? result : null;
    }
    public static void SetFromAttribute(this XElement? element, out string? value, [CallerArgumentExpression(nameof(value))] string name = "")
    {
        value = element?.Attribute(name)?.Value;
    }
}
