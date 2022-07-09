using System.Xml.Linq;

namespace QBSDK
{
    public interface IQBQuery
    {
        public XElement ToQueryRq(QBCountry qbCountry);
    }

    public abstract class QBQuery<T> : IQBQuery
    {
#pragma warning disable IDE1006 // Naming Styles - We use nameof(iterator) and QB requires to start with lowercase
        public Iterator? iterator { get; internal set; }

        public string iteratorID { get; internal set; }
#pragma warning restore IDE1006 // Naming Styles

        protected string QueryType = $"{typeof(T).Name}QueryRq";

        public void StopQuery()
        {
            if(iterator != null)
            {
                iterator = Iterator.Stop;
            }
        }

        public abstract XElement ToQueryRq(QBCountry qbCountry);
    }
}
