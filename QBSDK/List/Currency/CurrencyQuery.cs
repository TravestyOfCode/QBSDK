using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [XmlType("CurrencyQueryRq")]
    [XmlRoot("CurrencyQueryRq")]
    public class CurrencyQuery : Request<CurrencyQuery>
    {
        [XmlIgnore()]
        private Collection<string> _listID;

        [MaxLength(36)]
        [XmlElement("ListID")]
        public Collection<string> ListID
        {
            get => _listID;
            private set => _listID = value;
        }

        [XmlIgnore()]
        public bool ListIDSpecified => ListID.Count != 0;        

        [XmlIgnore()]
        private Collection<string> _fullName;

        [XmlElement("FullName")]
        public Collection<string> FullName
        {
            get => _fullName;
            private set => _fullName = value;
        }

        [XmlIgnore()]
        public bool FullNameSpecified => FullName.Count != 0;

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

        [XmlIgnore()]
        private Collection<string> _includeRetElement;

        [MaxLength(50)]
        [XmlElement("IncludeRetElement")]
        public Collection<string> IncludeRetElement
        {
            get => _includeRetElement;
            private set => _includeRetElement = value;
        }

        [XmlIgnore()]
        public bool IncludeRetElementSpecified => IncludeRetElement.Count != 0;

        [XmlAttribute("metaData")]
        public MetaData? MetaData { get; set; }

        [XmlIgnore()]
        public bool MetaDataSpecified => MetaData.HasValue;

        public CurrencyQuery()
        {
            _listID = new Collection<string>();
            _fullName = new Collection<string>();
            _includeRetElement = new Collection<string>();
        }
    }
}
