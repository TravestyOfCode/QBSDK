using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QBSDK.DataProvider
{
    public class QBDQueryProvider : QueryProvider
    {
        private readonly QueryTranslator _translator;

        private QBConnection _qbConnection;

        public QBDQueryProvider()
        {
            _qbConnection = new QBConnection(Assembly.GetCallingAssembly().GetName().Name);
            _translator = new QueryTranslator();
        }

        public QBDQueryProvider(QBConnection QBConnection)
        {
            _qbConnection = QBConnection;
            _translator = new QueryTranslator();
        }

        public override object Execute(Expression expression)
        {
            //Type elementType = TypeSystem.GetElementType(expression.Type);

            // TODO: Convert to a collection of DbSets?
            return _qbConnection.ProcessRequest(_translator.Translate(expression));            
        }

        public override string GetQueryText(Expression expression) => _translator.Translate(expression)?.ToString();
    
    }
}
