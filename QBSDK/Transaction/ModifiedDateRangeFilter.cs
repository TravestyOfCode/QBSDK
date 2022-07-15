using System;
using System.Xml;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ModifiedDateRangeFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("ModifiedDateRangeFilter", Namespace="")]
    public class ModifiedDateRangeFilter
    {        
        [XmlElement("FromModifiedDate")]
        public DateTime? FromModifiedDate { get; set; }

        [XmlIgnore()]
        public bool FromModifiedDateSpecified => FromModifiedDate.HasValue;

        [XmlElement("ToModifiedDate")]
        public DateTime? ToModifiedDate { get; set; }

        [XmlIgnore()]
        public bool ToModifiedDateSpecified => ToModifiedDate.HasValue;

        public ModifiedDateRangeFilter()
        {

        }

        public ModifiedDateRangeFilter(DateTime fromModifiedDate, DateTime toModifiedDate)
        {
            FromModifiedDate = fromModifiedDate;
            ToModifiedDate = toModifiedDate;
        }        
    }
}
