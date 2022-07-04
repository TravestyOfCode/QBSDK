using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QBSDK.DataProvider
{
    public class Example
    {
        class Program
        {
            static void Main()
            {
                List<Account> values = new List<Account>();

                var query = values.AsQueryable<Account>().Where(s => s.Name == ("H"));

                MethodCallExpression m = (MethodCallExpression)query.Expression;

                ConstantExpression c = (ConstantExpression)m.Arguments[0];

                IQueryable q = c.Value as IQueryable;

                XElement request = new XElement(q.ElementType.Name + "QueryRq");

                var l = (LambdaExpression)StripQuotes(m.Arguments[1]);

                XElement filter = null;
                // Check if this is a binary expression or method call
                if (l.Body is BinaryExpression)
                {
                    var left = ((BinaryExpression)l.Body).Left as MemberExpression;
                    var right = ((BinaryExpression)l.Body).Right as ConstantExpression;

                    switch (left?.Member?.Name)
                    {
                        case "Name":
                            filter = new XElement("NameFilter");
                            filter.Add(new XElement("MatchCriterion", "Contains"));
                            filter.Add(new XElement("Name", right.Value));
                            break;
                        case "AccountType":
                            filter = new XElement("AccountType", right.Value);
                            break;
                    }
                }
                else if (l.Body is MethodCallExpression)
                {
                    var mce = l.Body as MethodCallExpression;
                    switch (mce.Method.Name)
                    {
                        case "StartsWith":
                            break;

                        case "EndsWith":
                            break;

                        case "Contains":
                            break;
                    }
                }
                request.Add(filter);

                Console.WriteLine(request.ToString());
            }

            private static Expression StripQuotes(Expression e)
            {
                while (e.NodeType == ExpressionType.Quote)
                {
                    e = ((UnaryExpression)e).Operand;
                }

                return e;
            }
        }
    }
}
