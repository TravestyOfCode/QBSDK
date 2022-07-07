using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QBSDK.DataProvider
{
    public class QBDataSet<TEntity> : IQueryable<TEntity>
    {
        List<TEntity> _Entities = new List<TEntity>();

        public Type ElementType => typeof(TEntity);

        public Expression Expression => _Entities.AsQueryable().Expression;

        private QBDQueryProvider _Provider;
        public IQueryProvider Provider => _Provider;

        internal QBDataSet(QBConnection connection)
        {
            _Provider = new QBDQueryProvider(connection);

        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
