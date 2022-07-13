using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ShipToAddress", Namespace="", AnonymousType=true)]
    [XmlRoot("ShipToAddress", Namespace="")]
    public class ShipToAddress : Address
    {        
        [MaxLength(41)]
        [Required()]
        [XmlElement("Name")]
        public string Name { get; set; }
        
        [XmlElement("DefaultShipTo")]
        public string DefaultShipTo { get; set; }
    }
}
