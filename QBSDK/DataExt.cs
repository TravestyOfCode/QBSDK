using System.Xml.Linq;

namespace QBSDK
{
    public class DataExt
    {
        public string OwnerID { get; set; }
        public string DataExtName { get; set; }
        public string DataExtValue { get; set; }

        public bool IsEmpty => OwnerID == null && DataExtName == null && DataExtValue == null;
    }

    public static class DataExtExtensions
    {
        public static DataExt AsDataExt(this XElement element)
        {
            if (element == null || element.Name.LocalName != "DataExtRet")
            {
                return null;
            }

            DataExt result = new DataExt();

            foreach (XElement subElement in element.Elements())
            {
                switch (subElement.Name.LocalName)
                {
                    case nameof(result.OwnerID): result.OwnerID = subElement.AsString(); break;
                    case nameof(result.DataExtName): result.DataExtName = subElement.AsString(); break;
                    case nameof(result.DataExtValue): result.DataExtValue = subElement.AsString(); break;
                }
            }

            if (result.IsEmpty)
            {
                return null;
            }

            return result;
        }
    }
}
