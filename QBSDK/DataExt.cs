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

        public static DataExt Create(XElement element)
        {
            if (element == null)
                return null;

            DataExt result = new DataExt();
            result.Parse(element);
            return result;
        }
    }

    public static class DataExtExtensions
    {
        public static DataExt AsDataExt(this XElement element) => DataExt.Create(element);
    }
}
