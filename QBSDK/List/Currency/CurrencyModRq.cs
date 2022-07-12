using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CurrencyModRq")]
    [XmlRoot("CurrencyModRq")]
    public class CurrencyModRq : Request<CurrencyMod>
    {
        public CurrencyMod CurrencyMod { get; init; }

        internal CurrencyModRq() { }

        public CurrencyModRq(CurrencyMod currencyMod)
        {
            CurrencyMod = currencyMod;
        }
    }
}
