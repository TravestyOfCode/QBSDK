using System.Xml.Linq;

namespace QBSDK
{
    public interface IQBQuery
    {
        public XElement ToQueryRq(QBVersionInfo versionInfo);
    }

    public abstract class QBQuery<T> : IQBQuery
    {
        protected string QueryType = $"{typeof(T).Name}QueryRq";

        public abstract XElement ToQueryRq(QBVersionInfo versionInfo);
    }
}
