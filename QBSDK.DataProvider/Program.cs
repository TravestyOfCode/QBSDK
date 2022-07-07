using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using QBSDK;

namespace QBSDK.DataProvider
{
    class Program
    {
        static void Main()
        {

            QBConnection conn = new QBConnection();

            var query = conn.Accounts.Where(a => a.Name == "A" && a.Desc.Contains("1"));

            var m = (MethodCallExpression)query.Expression;

            query.Provider.Execute(query.Expression);
            
            //List<Account> values = new List<Account>();

            //var query = values.AsQueryable().Where(a => a.Name == "H");

            //MethodCallExpression m = (MethodCallExpression)query.Expression;

            //ConstantExpression c = (ConstantExpression)m.Arguments[0];

            //IQueryable q = c.Value as IQueryable;

            //XElement request = new XElement(q.ElementType.Name + "QueryRq");

            //var l = (LambdaExpression)StripQuotes(m.Arguments[1]);

            //XElement filter = null;
            //// Check if this is a binary expression or method call
            //if (l.Body is BinaryExpression)
            //{
            //    var left = ((BinaryExpression)l.Body).Left as MemberExpression;
            //    var right = ((BinaryExpression)l.Body).Right as ConstantExpression;

            //    switch (left?.Member?.Name)
            //    {
            //        case "Name":
            //            filter = new XElement("NameFilter");
            //            filter.Add(new XElement("MatchCriterion", "Contains"));
            //            filter.Add(new XElement("Name", right.Value));
            //            break;
            //        case "AccountType":
            //            filter = new XElement("AccountType", right.Value);
            //            break;
            //    }
            //}
            //else if (l.Body is MethodCallExpression)
            //{
            //    var mce = l.Body as MethodCallExpression;
            //    switch (mce.Method.Name)
            //    {
            //        case "StartsWith":
            //            break;

            //        case "EndsWith":
            //            break;

            //        case "Contains":
            //            break;
            //    }
            //}
            //request.Add(filter);

            //Console.WriteLine(request.ToString());
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