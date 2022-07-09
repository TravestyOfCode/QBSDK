using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public abstract class FullNameQuery<T> : QBQuery<T>
    {
        public List<string> FullNameList { get; set; }

        public List<string> IncludeRetElementList { get; set; }

        public List<string> OwnerIDList { get; set; }

        public FullNameQuery() : base()
        {
            FullNameList = new List<string>();
            IncludeRetElementList = new List<string>();
            OwnerIDList = new List<string>();
        }

        public FullNameQuery(params string[] ListIDs) : this()
        {
            foreach (var id in ListIDs)
            {
                FullNameList.Add(id);
            }
        }

        //public override XElement ToQueryRq(QBCountry qbCountry = QBCountry.US)
        //{
        //    XElement QueryRq = new XElement(nameof(QueryRq);

        //    FullNameList?.ForEach(FullName => QueryRq.Add(FullName.ToXElement(nameof(FullName))));

        //    IncludeRetElementList?.ForEach(IncludeRetElement => QueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

        //    OwnerIDList?.ForEach(OwnerID => QueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

        //    return QueryRq;
        //}
    }
}
