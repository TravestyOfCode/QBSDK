using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("EntityFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("EntityFilter", Namespace="")]
    public class EntityFilter
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

        [MaxLength(36)]
        [XmlElement("ListIDWithChildren")]
        public string ListIDWithChildren { get; set; }
        
        [XmlElement("FullNameWithChildren")]
        public string FullNameWithChildren { get; set; }

        public EntityFilter()
        {
            _listID = new Collection<string>();
            _fullName = new Collection<string>();
        }
    }
}
