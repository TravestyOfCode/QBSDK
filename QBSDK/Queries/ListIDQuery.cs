using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class ListIDQuery<T> : QBQuery<T>
    {
        public List<string> ListIDList { get; set; }

        public List<string> IncludeRetElementList { get; set; }

        public List<string> OwnerIDList { get; set; }

        public ListIDQuery() : base()
        {
            ListIDList = new List<string>();
            IncludeRetElementList = new List<string>();
            OwnerIDList = new List<string>();
        }

        public ListIDQuery(params string[] ListIDs) : this()
        {
            foreach (var id in ListIDs)
            {
                ListIDList.Add(id);
            }
        }

        public override XElement ToQueryRq(QBCountry qbCountry = QBCountry.US)
        {
            XElement QBXMLMsgsRq = new XElement(nameof(QBXMLMsgsRq));
            
            XElement QueryRq = new XElement(QueryType);

            ListIDList?.ForEach(ListID => QueryRq.Add(ListID.ToXElement(nameof(ListID))));

            IncludeRetElementList?.ForEach(IncludeRetElement => QueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => QueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            QBXMLMsgsRq.Add(QueryRq);
            
            return QBXMLMsgsRq;
        }

        public override string ToString() => ToQueryRq().ToString();
        
    }
}
