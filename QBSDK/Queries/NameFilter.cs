using System.Xml.Linq;

namespace QBSDK
{
    public class NameFilter
    {
        public MatchCriterion MatchCriterion { get; set; }

        public string Name { get; set; }

        public NameFilter()
        {
        }

        public NameFilter(string name, MatchCriterion matchCriterion = MatchCriterion.StartsWith)
        {
            MatchCriterion = matchCriterion;
            Name = name;
        }

        public XElement ToXElement(string name = nameof(NameFilter))
        {
            XElement results = new XElement(name);
            results.Add(new XElement(nameof(MatchCriterion), MatchCriterion));
            results.Add(new XElement(nameof(Name), Name));
            return results;
        }
    }
}
