using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public abstract class QBQuery<T>
    {
        internal Iterator? iterator;

        internal string iteratorID;

        private MetaData? metaData;
        public MetaData? MetaData { get => metaData; set => metaData = value; }

        private List<string> IncludeRetElement;
        public List<string> IncludeRetElementList { get => IncludeRetElement; set => IncludeRetElement = value; }

        private List<string> OwnerID;
        public List<string> OwnerIDList { get => OwnerID; set => OwnerID = value; }

        protected QBQuery()
        {

        }

        public virtual XElement ToXElement()
        {
            var QueryRq = new XElement($"{typeof(T)}QueryRq");

            QueryRq.Add(iterator.ToXAttribute(nameof(iterator)));
            QueryRq.Add(iteratorID.ToXAttribute(nameof(iteratorID)));

            // Clear any IncludRetElement or OwnerID elements
            QueryRq.Elements(nameof(IncludeRetElement)).Remove();
            QueryRq.Elements(nameof(OwnerID)).Remove();

            AddToXElement(QueryRq);

            return QueryRq;
        }

        public virtual XElement AddToXElement(XElement queryRq)
        {
            if (queryRq == null)
                return null;

            queryRq.Add(iterator.ToXAttribute(nameof(iterator)));
            queryRq.Add(iteratorID.ToXAttribute(nameof(iteratorID)));

            // Add the IncludeRetElement and OwnerID elements
            if (IncludeRetElement != null)
            {
                foreach (var i in IncludeRetElement)
                {
                    queryRq.Add(new XElement(nameof(IncludeRetElement), i));
                }
            }
            if (OwnerID != null)
            {
                foreach (var o in OwnerID)
                {
                    queryRq.Add(new XElement(nameof(OwnerID), o));
                }
            }

            return queryRq;
        }
    }

}
