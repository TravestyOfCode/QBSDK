using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class DataExt
    {
        public string OwnerID { get; set; }
        public string DataExtName { get; set; }
        public string DataExtValue { get; set; }

        public bool IsEmpty => OwnerID == null && DataExtName == null && DataExtValue == null;

        public void Parse(XElement element)
        {
            if (element == null)
                return;

            foreach(var subElement in element.Elements())
            {
                switch(subElement.Name.LocalName)
                {
                    case nameof(OwnerID): OwnerID = subElement.AsString(); break;
                    case nameof(DataExtName): DataExtName = subElement.AsString(); break;
                    case nameof(DataExtValue): DataExtValue = subElement.AsString(); break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(DataExt))
        {
            XElement result = new XElement(name);
            result.Add(OwnerID?.ToXElement(nameof(OwnerID)));
            result.Add(DataExtName?.ToXElement(nameof(DataExtName)));
            result.Add(DataExtValue?.ToXElement(nameof(DataExtValue)));
            return result;
        }

        public override string ToString() => ToString(null);

        public string ToString(string name) => ToXElement(name).ToString();

        public static DataExt Create(XElement element)
        {
            if (element == null)
                return null;

            DataExt result = new DataExt();
            result.Parse(element);
            return result;
        }

        public static implicit operator DataExt(XElement ret) => Create(ret);
    }

    public static class DataExtExtensions
    {
        public static List<XElement> ToXElement(this List<DataExt> values, string name = nameof(DataExt))
        {
            if (values == null)
                return null;

            List<XElement> results = new List<XElement>();
            foreach(var value in values)
            {
                results.Add(value.ToXElement(name));
            }
            return results;
        }
    }
}
