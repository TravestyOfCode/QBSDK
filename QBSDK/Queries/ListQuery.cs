using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class ListQuery<T> : QBQuery<T>
    {
#pragma warning disable IDE1006 // Naming Styles - We use nameof(metaData) and QB requires to start with lowercase
        public MetaData? metaData { get; set; }
#pragma warning restore IDE1006 // Naming Styles

        public ActiveStatus? ActiveStatus { get; set; }

        public DateTime? FromModifiedDate { get; set; }

        public DateTime? ToModifiedDate { get; set; }

        private NameFilter nameFilter;
        public NameFilter NameFilter
        {
            get => nameFilter;
            set
            {
                if (nameRangeFilter != null)
                    throw new InvalidOperationException("Unable to set NameFilter while there is an active NameRangeFilter.");

                nameFilter = value;
            }
        }

        private NameRangeFilter nameRangeFilter;
        public NameRangeFilter NameRangeFilter
        {
            get => nameRangeFilter;
            set
            {
                if (nameFilter != null)
                    throw new InvalidOperationException("Unable to set NameRangeFilter while there is an active NameFilter.");

                nameRangeFilter = value;
            }
        }

        public List<string> IncludeRetElementList { get; set; }

        public List<string> OwnerIDList { get; set; }

        public override XElement ToQueryRq(QBCountry qbCountry = QBCountry.US)
        {
            XElement QueryRq = new XElement($"{typeof(T).Name}QueryRq");

            QueryRq.Add(metaData.ToXAttribute(nameof(metaData)));

            QueryRq.Add(ActiveStatus.ToXElement(nameof(ActiveStatus)));

            QueryRq.Add(FromModifiedDate.ToXElement(nameof(FromModifiedDate)));

            QueryRq.Add(ToModifiedDate.ToXElement(nameof(ToModifiedDate)));

            QueryRq.Add(NameFilter.ToXElement(nameof(NameFilter)));

            QueryRq.Add(NameRangeFilter.ToXElement(nameof(NameRangeFilter)));

            IncludeRetElementList?.ForEach(IncludeRetElement => QueryRq.Add(IncludeRetElement.ToXElement(nameof(IncludeRetElement))));

            OwnerIDList?.ForEach(OwnerID => QueryRq.Add(OwnerID.ToXElement(nameof(OwnerID))));

            return QueryRq;
        }
    }
}
