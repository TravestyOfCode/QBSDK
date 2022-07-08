using System.Xml.Linq;

namespace QBSDK
{
    public interface IQBQuery
    {
        public XElement ToQueryRq(QBVersionInfo versionInfo);
    }

    public abstract class QBQuery<T> : IQBQuery
    {
        public Iterator? iterator { get; internal set; }

        public string iteratorID { get; internal set; }

        protected string QueryType = $"{typeof(T).Name}QueryRq";

        public abstract XElement ToQueryRq(QBVersionInfo versionInfo);
    }
}
