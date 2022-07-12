using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CurrencyAdd", Namespace="", AnonymousType=true)]
    [XmlRoot("CurrencyAdd", Namespace="")]
    public partial class CurrencyAdd
    {        
        [MaxLength(64)]
        [Required()]
        [XmlElement("Name")]
        public string Name { get; set; }
        
        [XmlElement("IsActive")]
        public string IsActive { get; set; }
        
        [MaxLength(3)]
        [Required()]
        [XmlElement("CurrencyCode")]
        public string CurrencyCode { get; set; }
        
        [XmlElement("CurrencyFormat")]
        public CurrencyFormat CurrencyFormat { get; set; }
    }
}
