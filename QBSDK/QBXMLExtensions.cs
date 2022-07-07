using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public static class QBXMLExtensions
    {
        public static XElement ToXElement(this Enum value, string name) => value == null ? null : new XElement(name, value);
        public static List<XElement> ToXElementList<T>(this List<T> values, string name) where T : Enum
        {
            if (values == null)
                return null;

            List<XElement> results = new List<XElement>();
            foreach (var e in values)
                results.Add(e.ToXElement(name));
            return results;
        }
        public static XElement ToXElement(this int? value, string name) => value == null ? null : value.Value.ToXElement(name);
        public static XElement ToXElement(this int value, string name) => new XElement(name, value);
        public static XElement ToXElement(this DateTime? value, string name) => value == null ? null : value.Value.ToXElement(name);
        public static XElement ToXElement(this DateTime value, string name) => new XElement(name, value.ToString("yyyy-MM-dd"));
        public static XElement ToXElement(this string value, string name) => value == null ? null : new XElement(name, value);
        public static XElement ToXElement(this decimal value, string name, int decimalPlaces = 2) => new XElement(name, value.ToString($"F{decimalPlaces}"));
        public static XElement ToXElement(this decimal? value, string name, int decimalPlaces = 2) => value == null ? null : value.Value.ToXElement(name, decimalPlaces);
        public static XElement ToXElement(this bool value, string name) => new XElement(name, value ? "true" : "false");
        public static XElement ToXElement(this bool? value, string name) => value == null ? null : value.Value.ToXElement(name);

        public static XAttribute ToXAttribute(this Enum value, string name) => value == null ? null : new XAttribute(name, value);
        public static XAttribute ToXAttribute(this string value, string name) => value == null ? null : new XAttribute(name, value);

        public static string AsString(this XElement element) => element?.Value;
        public static Nullable<T> AsEnum<T>(this XElement element) where T : struct
        {
            if (element == null)
                return null;

            if (Enum.TryParse<T>(element?.Value, out T result))
                return result;

            return null;                
        }
        public static decimal? AsDecimal(this XElement element) => decimal.TryParse(element?.Value, out decimal result) == true ? result : null;
        public static int? AsInt(this XElement element) => int.TryParse(element?.Value, out int result) == true ? result : null;
        public static bool? AsBool(this XElement element)
        {
            if (element == null || element.Value == null)
                return null;

            if (element.Value == "true")
                return true;
            else if (element.Value == "false")
                return false;
            return null;
        }
    }
}
