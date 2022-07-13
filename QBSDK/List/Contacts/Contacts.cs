using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ContactsRet", Namespace="", AnonymousType=true)]
    [XmlRoot("ContactsRet", Namespace="")]
    public class Contacts
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [Required()]
        [XmlElement("TimeCreated")]
        public DateTime TimeCreated { get; set; }
        
        [Required()]
        [XmlElement("TimeModified")]
        public DateTime TimeModified { get; set; }
        
        [MaxLength(16)]
        [XmlElement("EditSequence")]
        public string EditSequence { get; set; }
        
        [MaxLength(41)]
        [XmlElement("Contact")]
        public string Contact { get; set; }
        
        [MaxLength(15)]
        [XmlElement("Salutation")]
        public string Salutation { get; set; }
        
        [MaxLength(25)]
        [Required()]
        [XmlElement("FirstName")]
        public string FirstName { get; set; }
        
        [MaxLength(5)]
        [XmlElement("MiddleName")]
        public string MiddleName { get; set; }
        
        [MaxLength(25)]
        [XmlElement("LastName")]
        public string LastName { get; set; }
        
        [MaxLength(41)]
        [XmlElement("JobTitle")]
        public string JobTitle { get; set; }
        
        [XmlIgnore()]
        private Collection<AdditionalContactRef> _additionalContactRef;
        
        [XmlElement("AdditionalContactRef")]
        public Collection<AdditionalContactRef> AdditionalContactRef
        {
            get => _additionalContactRef;
            private set => _additionalContactRef = value;
        }

        [XmlIgnore()]
        public bool AdditionalContactRefSpecified => AdditionalContactRef.Count != 0;

        public Contacts()
        {
            _additionalContactRef = new Collection<AdditionalContactRef>();
        }
    }
}
