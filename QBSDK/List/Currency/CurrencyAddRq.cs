using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CurrencyAddRq")]
    [XmlRoot("CurrencyAddRq")]
    public class CurrencyAddRq : Request<CurrencyAdd>
    {
        public CurrencyAdd CurrencyAdd { get; init; }

        internal CurrencyAddRq() { }

        public CurrencyAddRq(CurrencyAdd currencyAdd)
        {
            CurrencyAdd = currencyAdd;
        }
    }
}
