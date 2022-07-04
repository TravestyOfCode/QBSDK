using System.Xml.Linq;

namespace QBSDK.Lists
{
    public struct TaxLineInfo
    {
        public int? TaxLineID { get; internal set; }
        public string TaxLineName { get; internal set; }

        public bool IsEmpty => TaxLineID == null && TaxLineName == null;
    }

    public static class TaxLineInfoExtensions
    {
        public static TaxLineInfo? AsTaxLineInfo(this XElement element)
        {
            if(element == null)
            {
                return null;
            }

            TaxLineInfo result = new TaxLineInfo();

            foreach (var subElement in element.Elements())
            {
                switch(subElement.Name.LocalName)
                {
                    case nameof(result.TaxLineID): result.TaxLineID = subElement.AsInt(); break;
                    case nameof(result.TaxLineName): result.TaxLineName = subElement.AsString(); break;
                }
            }

            return result.IsEmpty ? null : result;
        }

#pragma warning disable IDE0060 // Remove unused parameter: name is for consistencey of AsXElement calls. QBSDK only uses TaxLineID as a standalone value
        public static XElement AsXElement(this TaxLineInfo? value, string name) => value == null ? null : new XElement(nameof(value.Value.TaxLineID), value.Value.TaxLineID);
        public static XElement AsXElement(this TaxLineInfo value, string name) => new XElement(nameof(value.TaxLineID), value.TaxLineID);
#pragma warning restore IDE0060 // Remove unused parameter
        
    }
}
