using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace QBSDK.DataProvider
{
    public abstract class QueryProvider : IQueryProvider
    {
        protected QueryProvider()
        {
        }

        IQueryable<TEntity> IQueryProvider.CreateQuery<TEntity>(Expression expression) => new Query<TEntity>(this, expression);

        IQueryable IQueryProvider.CreateQuery(Expression expression)
        {
            Type elementType = TypeSystem.GetElementType(expression.Type);

            try
            {
                return (IQueryable)Activator.CreateInstance(typeof(Query<>).MakeGenericType(elementType), new object[] { this, expression });
            }
            catch (TargetInvocationException tie)
            {
                throw tie.InnerException;
            }
        }

        TEntity IQueryProvider.Execute<TEntity>(Expression expression) => (TEntity)Execute(expression);

        object IQueryProvider.Execute(Expression expression) => Execute(expression);
        
        public abstract string GetQueryText(Expression expression);

        public abstract object Execute(Expression expression);

    }
}
