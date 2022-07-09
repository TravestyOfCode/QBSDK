using System.Xml.Linq;

namespace QBSDK
{
    public class TaxLineInfo
    {
        public int? TaxLineID { get; internal set; }
        public string TaxLineName { get; internal set; }

        public bool IsEmpty => TaxLineID == null && TaxLineName == null;

        public void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(TaxLineID): TaxLineID = element.AsInt(); break;
                    case nameof(TaxLineName): TaxLineName = element.AsString(); break;
                }
            }
        }

        public static TaxLineInfo Create(XElement ret)
        {
            if (ret == null)
                return null;

            TaxLineInfo result = new TaxLineInfo();
            result.Parse(ret);
            return result;
        }
    }

    public static class TaxLineInfoExtensions
    {
        public static TaxLineInfo AxTaxLineInfo(this XElement ret) => TaxLineInfo.Create(ret);
    }
}
