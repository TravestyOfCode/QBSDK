using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [XmlType("AccountQueryRq")]
    [XmlRoot("AccountQueryRq")]
    public class AccountQuery : Request<AccountQuery>
    {
        [XmlIgnore()]
        private Collection<string> _listID;

        [MaxLength(36)]
        [XmlElement("ListID")]
        public Collection<string> ListID
        {
            get
            {
                return _listID;
            }
            private set
            {
                _listID = value;
            }
        }

        [XmlIgnore()]
        public bool ListIDSpecified => ListID.Count != 0;

        [XmlIgnore()]
        private Collection<string> _fullName;

        [MaxLength(36)]
        [XmlElement("FullName")]
        public Collection<string> FullName
        {
            get
            {
                return _fullName;
            }
            private set
            {
                _fullName = value;
            }
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
        private Collection<AccountType> _accountType;

        [XmlElement("AccountType")]
        public Collection<AccountType> AccountType
        {
            get
            {
                return _accountType;
            }
            private set
            {
                _accountType = value;
            }
        }

        [XmlIgnore()]
        public bool AccountTypeSpecified => AccountType.Count != 0;

        [XmlElement("CurrencyFilter")]
        public CurrencyFilter CurrencyFilter { get; set; }

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

        [XmlIgnore()]
        private Collection<string> _ownerID;

        [RegularExpression("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [XmlElement("OwnerID")]
        public Collection<string> OwnerID
        {
            get => _ownerID;
            private set => _ownerID = value;
        }

        [XmlIgnore()]
        public bool OwnerIDSpecified => OwnerID.Count != 0;
                        
        [XmlIgnore()]
        public MetaData? MetaData { get; set; }

        [XmlAttribute("metaData")]
        internal string MetaDataString => MetaData?.ToString();

        [XmlIgnore()]
        public bool MetaDataSpecified => MetaData.HasValue;

        public AccountQuery()
        {
            _listID = new Collection<string>();
            _fullName = new Collection<string>();
            _accountType = new Collection<AccountType>();
            _includeRetElement = new Collection<string>();
            _ownerID = new Collection<string>();
        }
    }
}
