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

        public void Parse(XElement CreditCardInfoRet)
        {
            if (CreditCardInfoRet == null)
                return;

            foreach (var element in CreditCardInfoRet.Elements())
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

        public static CreditCardInfo Create(XElement CreditCardInfoRet)
        {
            if (CreditCardInfoRet == null)
                return null;

            CreditCardInfo result = new CreditCardInfo();
            result.Parse(CreditCardInfoRet);
            return result;
        }
    }

    public static class CreditCardInfoExtensions
    {
        public static CreditCardInfo AsCreditCardInfo(this XElement element) => CreditCardInfo.Create(element);
    }
}
