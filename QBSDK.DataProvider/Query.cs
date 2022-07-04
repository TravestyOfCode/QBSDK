using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QBSDK.DataProvider
{
    public class Query<T> : IQueryable<T>, IQueryable, IEnumerable<T>, IEnumerable, IOrderedQueryable<T>, IOrderedQueryable
    {
        private readonly QueryProvider _provider;

        private readonly Expression _expression;

        Expression IQueryable.Expression => _expression;

        Type IQueryable.ElementType => typeof(T);

        IQueryProvider IQueryable.Provider => _provider;

        public Query(QueryProvider provider)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));

            _expression = Expression.Constant(this);
        }

        public Query(QueryProvider provider, Expression expression)
        {
            if (!typeof(IQueryable<T>).IsAssignableFrom(expression.Type))
            {
                throw new ArgumentOutOfRangeException(nameof(expression));
            }

            _provider = provider ?? throw new ArgumentNullException(nameof(provider));

            _expression = expression ?? throw new ArgumentNullException(nameof(expression));
        }

        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_provider.Execute(_expression)).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_provider.Execute(_expression)).GetEnumerator();

        public override string ToString() => _provider.GetQueryText(_expression);
    }
}
