using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{   
    [Serializable()]
    [XmlType("CurrencyMod", Namespace="", AnonymousType=true)]
    [XmlRoot("CurrencyMod", Namespace="")]
    public class CurrencyMod
    {
        [MaxLength(36)]
        [Required()]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(16)]
        [Required()]
        [XmlElement("EditSequence")]
        public string EditSequence { get; set; }
        
        [MaxLength(64)]
        [XmlElement("Name")]
        public string Name { get; set; }
        
        [XmlElement("IsActive")]
        internal string IsActiveString
        {
            get => IsActive == null ? null : (IsActive.Value ? "true" : "false");
            set => IsActive = value == null ? null : value == "true";
        }

        [XmlIgnore()]
        public bool? IsActive { get; set; }
        
        [MaxLength(3)]
        [XmlElement("CurrencyCode")]
        public string CurrencyCode { get; set; }
        
        [XmlElement("CurrencyFormat")]
        public CurrencyFormat CurrencyFormat { get; set; }
    }
}
