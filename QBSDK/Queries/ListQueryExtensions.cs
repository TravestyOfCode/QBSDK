using Microsoft.EntityFrameworkCore;
using QBSDK.Lists;
using System.Xml.Linq;

namespace QBSDK.Queries
{
    public static class ListQueryExtensions
    {        
        public static DbSet<TEntity> GetByListID<TEntity>(this QBDBContext dbContext, params string[] listIDs) where TEntity : QBListObject
        {
            XElement QBXMLMsgsRq = new XElement(nameof(QBXMLMsgsRq));
            XElement QueryRq = new XElement(typeof(TEntity).Name + "QueryRq");
            
            foreach(var ListID in listIDs)
            {
                QueryRq.Add(new XElement(nameof(ListID), ListID));
            }

            QBXMLMsgsRq.Add(QueryRq);

            return dbContext.ProcessQuery<TEntity>(QBXMLMsgsRq);
        }
    }
}
