using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CurrencyFormat", Namespace="", AnonymousType=true)]
    [XmlRoot("CurrencyFormat", Namespace="")]
    public class CurrencyFormat
    {   
        [XmlElement("ThousandSeparator")]
        public ThousandSeparator? ThousandSeparator { get; set; }

        [XmlIgnore()]
        public bool ThousandSeparatorSpecified => ThousandSeparator.HasValue;
        
        [XmlElement("ThousandSeparatorGrouping")]
        public ThousandSeparatorGrouping? ThousandSeparatorGrouping { get; set; }

        [XmlIgnore()]
        public bool ThousandSeparatorGroupingSpecified => ThousandSeparatorGrouping.HasValue;
        
        [XmlElement("DecimalPlaces")]
        public DecimalPlaces? DecimalPlaces { get; set; }

        [XmlIgnore()]
        public bool DecimalPlacesSpecified => DecimalPlaces.HasValue;
        
        [XmlElement("DecimalSeparator")]
        public DecimalSeparator? DecimalSeparator { get; set; }

        [XmlIgnore()]
        public bool DecimalSeparatorSpecified => DecimalSeparator.HasValue;
    }
}
