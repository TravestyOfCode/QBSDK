using System;
using System.Xml.Serialization;

namespace QBSDK
{
    public abstract class ListFilter
    {
        [XmlElement("MaxReturned")]
        public int? MaxReturned { get; set; }

        [XmlIgnore()]
        public bool MaxReturnedSpecified => MaxReturned.HasValue;

        [XmlElement("ActiveStatus")]
        public ActiveStatus? ActiveStatus { get; set; }

        [XmlIgnore()]
        public bool ActiveStatusSpecified => ActiveStatus.HasValue;

        [XmlElement("FromModifiedDate")]
        public DateTime? FromModifiedDate { get; set; }

        [XmlIgnore()]
        public bool FromModifiedDateSpecified => FromModifiedDate.HasValue;

        [XmlElement("ToModifiedDate")]
        public DateTime? ToModifiedDate { get; set; }

        [XmlIgnore()]
        public bool ToModifiedDateSpecified => ToModifiedDate.HasValue;

        [XmlElement("NameFilter")]
        public NameFilter NameFilter { get; set; }

        [XmlElement("NameRangeFilter")]
        public NameRangeFilter NameRangeFilter { get; set; }
    }
}
