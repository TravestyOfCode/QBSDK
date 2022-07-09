using System.Xml.Linq;

namespace QBSDK
{
    public class CreditCardInfo
    {
        public string CreditCardNumber { get; set; }
        public int? ExpirationMonth { get; set; }
        public int? ExpirationYear { get; set; }
        public string NameOnCard { get; set; }
        public string CreditCardAddress { get; set; }
        public string CreditCardPostalCode { get; set; }

        public void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach (var element in ret.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(CreditCardNumber): CreditCardNumber = element.AsString(); break;
                    case nameof(ExpirationMonth): ExpirationMonth = element.AsInt(); break;
                    case nameof(ExpirationYear): ExpirationYear = element.AsInt(); break;
                    case nameof(NameOnCard): NameOnCard = element.AsString(); break;
                    case nameof(CreditCardAddress): CreditCardAddress = element.AsString(); break;
                    case nameof(CreditCardPostalCode): CreditCardPostalCode = element.AsString(); break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(CreditCardInfo))
        {
            XElement result = new XElement(name);
            result.Add(CreditCardNumber.ToXElement(nameof(CreditCardNumber)));
            result.Add(ExpirationMonth.ToXElement(nameof(ExpirationMonth)));
            result.Add(ExpirationYear.ToXElement(nameof(ExpirationYear)));
            result.Add(NameOnCard.ToXElement(nameof(NameOnCard)));
            result.Add(CreditCardAddress.ToXElement(nameof(CreditCardAddress)));
            result.Add(CreditCardPostalCode.ToXElement(nameof(CreditCardPostalCode)));
            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();

        public static CreditCardInfo Create(XElement ret)
        {
            if (ret == null)
                return null;

            CreditCardInfo result = new CreditCardInfo();
            result.Parse(ret);
            return result;
        }

        public static implicit operator CreditCardInfo(XElement ret) => Create(ret);
    }
}
