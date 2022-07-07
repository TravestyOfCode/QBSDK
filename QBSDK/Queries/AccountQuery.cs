using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QBSDK
{
    public class AccountQuery : ComplexListQuery<Account>
    {
        public new int? MaxReturned
        {
            get => null;
            set => throw new InvalidOperationException("MaxReturned cannot be set for an AccountQuery");
        }

        private List<AccountType> AccountType;
        public List<AccountType> AccountTypeList { get => AccountType; set => AccountType = value; }

        public BaseRefFilter CurrencyFilter { get; set; }

        public override XElement ToXElement()
        {
            var QueryRq = new XElement("AccountQueryRq");

            // Set MaxReturned to null as that will prevent iterator from being set
            base.MaxReturned = null;

            base.AddToXElement(QueryRq);

            AddToXElement(QueryRq);

            ((QBQuery<Account>)this).AddToXElement(QueryRq);

            return QueryRq;
        }

        public new XElement AddToXElement(XElement queryRq)
        {
            if (queryRq == null)
                return null;

            queryRq.Add(AccountType?.ToXElementList(nameof(AccountType)));
            queryRq.Add(CurrencyFilter?.ToXElement(nameof(CurrencyFilter)));

            return queryRq;
        }

    }
}
