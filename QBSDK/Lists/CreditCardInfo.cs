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

        public static CreditCardInfo Create(XElement ret)
        {
            if (ret == null)
                return null;

            CreditCardInfo result = new CreditCardInfo();
            result.Parse(ret);
            return result;
        }
    }

    public static class CreditCardInfoExtensions
    {
        public static CreditCardInfo AsCreditCardInfo(this XElement ret) => CreditCardInfo.Create(ret);
    }
}
