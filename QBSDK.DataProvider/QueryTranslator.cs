using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QBSDK.DataProvider
{
    internal class QueryTranslator : ExpressionVisitor
    {
        private XElement request = null;

        internal QueryTranslator()
        {
        }

        internal string Translate(Expression expression)
        {
            this.Visit(expression);

            return request?.ToString();
        }

        private static Expression StripQuotes(Expression e)
        {
            while(e.NodeType == ExpressionType.Quote)
            {
                e = ((UnaryExpression)e).Operand;
            }

            return e;
        }

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Where")
            {
                if (m.Arguments[0] is not ConstantExpression sourceExp)
                    throw new InvalidOperationException("Unable to convert query to QBXML.");

                // We are expecting a value for the table, not any other constant
                if (sourceExp.Value is not IQueryable table)
                    throw new InvalidOperationException("Unable to convert query to QBXML.");

                request = new XElement(table.ElementType.Name + "QueryRq");

                // We should have a lambda expression for the second argument
                if (StripQuotes(m.Arguments[1]) is not LambdaExpression lambdaExp)
                    throw new InvalidOperationException("Unable to convert query to QBXML.");

                XElement filter = null;

                // Will need to support BinaryExpression for string fields with Equals or MethodCallExpression with "StartsWith", "Contains", or "EndsWith"
                // and BinaryExpression for amount and date types. Also binary expression that contains other binary (i.e. s.ModifiedDate >= XXX && s.ModifiedDate <= XXX)
                //var methodExp = lambdaExp.Body as MethodCallExpression;

                if (lambdaExp.Body is BinaryExpression binaryExp && binaryExp.NodeType == ExpressionType.Equal)
                {
                    // Left should be the property that we are filtering, right is our filter value
                    if (binaryExp.Left is not MemberExpression left || binaryExp.Right is not ConstantExpression right)
                        throw new InvalidOperationException("Unable to convert query to QBXML.");

                    switch (left.Member.Name)
                    {
                        case "Name":
                            filter = new XElement("NameFilter");
                            filter.Add(new XElement("MatchCriterion", "Contains"));
                            filter.Add(new XElement("Name", right.Value));
                            break;

                        case "AccountType":
                        case "PaymentMethodType":
                            filter = new XElement(left.Member.Name, right.Value);
                            break;
                    }
                }

                request.Add(filter);

            }
            return null;
        }
    }
}
