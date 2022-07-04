using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public static class XElementExtensions
    {
        public static string AsString(this XElement element) => element?.Value;

        public static XElement AsXElement(this string value, string name) => new XElement(name, value);
        
        public static DateTime? AsDateTime(this XElement element)
        {
            if(element == null)
            {
                return null;
            }

            return DateTime.TryParse(element?.Value, out DateTime result) ? result : null;
        }

        public static XElement AsXElement(this DateTime? value, string name) => value?.AsXElement(name);

        public static XElement AsXElement(this DateTime value, string name) => new XElement(name, value.ToString("yyyy-MM-dd"));

        public static bool? AsBool(this XElement element)
        {
            if (element == null)
            {
                return null;
            }

            string value = element?.Value.ToUpper();

            return value == "TRUE" || value == "YES" || value == "1";
        }

        public static XElement AsXElement(this bool? value, string name) => value == null ? null : new XElement(name, value.Value ? "true" : "false");

        public static XElement AsXElement(this bool value, string name) => new(name, value ? "true" : "false");

        public static Nullable<T> AsEnum<T>(this XElement element) where T : struct
        {
            if (element == null)
            {
                return null;
            }

            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type.");
            }

            return Enum.TryParse<T>(element?.Value, out T result) ? result : null;
        }

        public static XElement AsXElement(this Enum value, string name) => value == null ? null : new XElement(name, value);

        public static decimal? AsDecimal(this XElement element) => decimal.TryParse(element?.Value, out decimal result) ? result : null;

        public static XElement AsXElement(this decimal? value, string name, int decimalPlaces = 2) => value?.AsXElement(name, decimalPlaces);

        public static XElement AsXElement(this decimal value, string name, int decimalPlaces = 2) => new(name, value.ToString($"F{decimalPlaces}"));

        public static int? AsInt(this XElement element) => int.TryParse(element?.Value, out int result) ? result : null;
        
    }
}
