using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CurrencyFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("CurrencyFilter", Namespace="")]
    public class CurrencyFilter
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

        public CurrencyFilter()
        {
            _listID = new Collection<string>();
            _fullName = new Collection<string>();
        }
        
        [XmlIgnore()]
        private Collection<string> _fullName;
        
        [MaxLength(64)]
        [XmlElement("FullName")]
        public Collection<string> FullName
        {
            get => _fullName;
            private set => _fullName = value;
        }

        [XmlIgnore()]
        public bool FullNameSpecified => FullName.Count != 0;
    }
}
