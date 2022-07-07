using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{    
    public class ListIDQuery<T> : QBQuery<T>
    {
        private List<string> ListID;
        public List<string> ListIDList { get => ListID; set => ListID = value; }        

        public ListIDQuery() : base()
        {
        }

        public ListIDQuery(params string[] ListIDs) : this()
        {
            ListID = new List<string>();
            foreach(var id in ListIDs)
            {
                this.ListID.Add(id);
            }
        }

        public override XElement ToXElement()
        {
            var QueryRq = new XElement($"{typeof(T)}QueryRq");

            AddToXElement(QueryRq);

            base.AddToXElement(QueryRq);

            return QueryRq;
        }

        public new XElement AddToXElement(XElement queryRq)
        {
            if (queryRq == null)
                return null;

            // Clear out any existing ListIDs
            queryRq.Elements(nameof(ListID)).Remove();

            // Add ListIDs
            foreach (var id in ListID)
            {
                queryRq.Add(new XElement(nameof(ListID), id));
            }

            return queryRq;
        }

        public override string ToString()
        {
            return ToXElement().ToString();
        }
    }

    public class FullNameQuery<T> : QBQuery<T>
    {
        private List<string> FullName;
        public List<string> FullNameList { get => FullName; set => FullName = value; }

        public FullNameQuery() : base()
        {
        }

        public FullNameQuery(params string[] FullNames) : this()
        {
            FullName = new List<string>();
            foreach (var id in FullNames)
            {
                FullName.Add(id);
            }
        }

        public override XElement ToXElement()
        {
            var QueryRq = new XElement($"{typeof(T)}QueryRq");

            AddToXElement(QueryRq);

            base.AddToXElement(QueryRq);

            return QueryRq;
        }

        public new XElement AddToXElement(XElement queryRq)
        {
            if (queryRq == null)
                return null;

            // Clear out any existing FullNames
            queryRq.Elements(nameof(FullName)).Remove();

            // Add FullNames at the top
            foreach (var id in FullName)
            {
                queryRq.Add(new XElement(nameof(FullName), id));
            }

            return queryRq;
        }

        public override string ToString()
        {
            return ToXElement().ToString();
        }
    }

    public class ComplexListQuery<T>  : QBQuery<T> // : IQueryRq where T : QBList
    {
        private int? maxReturned;
        public int? MaxReturned
        {
            get => maxReturned;
            set
            {
                if (value == null)
                {
                    iterator = null;
                    iteratorID = null;
                }
                else
                {
                    if (iterator == null)
                    {
                        iterator = Iterator.Start;
                        iteratorID = null;
                    }
                }
                maxReturned = value;
            }
        }

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
                    throw new InvalidOperationException("Unable to set NameFilter with existing NameRangeFilter.");

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
                    throw new InvalidOperationException("Unable to set NameRangeFilter with existing NameFilter.");

                nameRangeFilter = value;
            }
        }

        public override XElement ToXElement()
        {
            var QueryRq = new XElement($"{typeof(T)}QueryRq");

            if(MaxReturned != null)
            {
                if(iteratorID == null)
                {
                    // Start a new iteration
                    iterator = Iterator.Start;
                }
                else
                {
                    // Continue iteration
                    iterator = Iterator.Continue;
                }
            }

            AddToXElement(QueryRq);
            
            base.AddToXElement(QueryRq);

            return QueryRq;
        }

        public new XElement AddToXElement(XElement queryRq)
        {
            if (queryRq == null)
                return null;

            queryRq.Add(MaxReturned?.ToXElement(nameof(MaxReturned)));
            queryRq.Add(ActiveStatus?.ToXElement(nameof(ActiveStatus)));
            queryRq.Add(FromModifiedDate?.ToXElement(nameof(FromModifiedDate)));
            queryRq.Add(ToModifiedDate?.ToXElement(nameof(ToModifiedDate)));
            queryRq.Add(NameFilter?.ToXElement(nameof(NameFilter)));
            queryRq.Add(NameRangeFilter?.ToXElement(nameof(NameRangeFilter)));

            return queryRq;

        }

        public override string ToString()
        {
            return ToXElement().ToString();
        }

    }
}
