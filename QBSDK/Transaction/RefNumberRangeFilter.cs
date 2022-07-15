using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("RefNumberRangeFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("RefNumberRangeFilter", Namespace="")]
    public class RefNumberRangeFilter
    {        
        [XmlElement("FromRefNumber")]
        public string FromRefNumber { get; set; }
        
        [XmlElement("ToRefNumber")]
        public string ToRefNumber { get; set; }

        public RefNumberRangeFilter()
        {

        }

        public RefNumberRangeFilter(string fromRefNumber, string toRefNumber)
        {
            FromRefNumber = fromRefNumber;
            ToRefNumber = toRefNumber;
        }
    }
}
