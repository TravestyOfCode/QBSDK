using System.Xml.Linq;

namespace QBSDK
{
    public class TotalBalanceFilter
    {
        public Operator Operator { get; set; }

        public decimal Amount { get; set; }

        public TotalBalanceFilter()
        {

        }

        public TotalBalanceFilter(decimal amount, Operator op = Operator.LessThan)
        {
            Amount = amount;
            Operator = op;
        }

        public XElement ToXElement(string name = nameof(TotalBalanceFilter))
        {
            XElement result = new XElement(name);
            result.Add(Operator.ToXElement(nameof(Operator)));
            result.Add(Amount.ToXElement(nameof(Amount)));
            return result;
        }
    }
}
