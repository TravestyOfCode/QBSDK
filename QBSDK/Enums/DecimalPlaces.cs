using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("DecimalPlaces", Namespace="", AnonymousType=true)]
    [XmlRoot("DecimalPlaces", Namespace="")]
    public enum DecimalPlaces
    {        
        [XmlEnum("0")]
        Item0,

        [XmlEnum("2")]
        Item2,
    }
}
