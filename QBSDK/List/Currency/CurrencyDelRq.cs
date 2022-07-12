using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ListDelRq")]
    [XmlRoot("ListDelRq")]
    public class CurrencyDelRq : Request<CurrencyDel>
    {
        public CurrencyDel CurrencyDel { get; init; }

        internal CurrencyDelRq() { }

        public CurrencyDelRq(CurrencyDel currencyDel)
        {
            CurrencyDel = currencyDel;
        }
    }
}
