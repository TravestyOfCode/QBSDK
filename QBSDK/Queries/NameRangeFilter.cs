using System.Xml.Linq;

namespace QBSDK
{
    public class NameRangeFilter
    {
        public string FromName { get; set; }

        public string ToName { get; set; }

        public NameRangeFilter()
        {

        }
        public NameRangeFilter(string fromName, string toName)
        {
            FromName = fromName;
            ToName = toName;
        }

        public XElement ToXElement(string name = nameof(NameRangeFilter))
        {
            XElement results = new XElement(name);
            results.Add(new XElement(nameof(FromName), FromName));
            results.Add(new XElement(nameof(ToName), ToName));
            return results;
        }
    }
}
