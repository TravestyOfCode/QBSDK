using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AddressBlock", Namespace="", AnonymousType=true)]
    [XmlRoot("AddressBlock", Namespace="")]
    public class AddressBlock
    {        
        [MaxLength(41)]
        [XmlElement("Addr1")]
        public string Addr1 { get; set; }
        
        [MaxLength(41)]
        [XmlElement("Addr2")]
        public string Addr2 { get; set; }
        
        [MaxLength(41)]
        [XmlElement("Addr3")]
        public string Addr3 { get; set; }
        
        [MaxLength(41)]
        [XmlElement("Addr4")]
        public string Addr4 { get; set; }
        
        [MaxLength(41)]
        [XmlElement("Addr5")]
        public string Addr5 { get; set; }
    }
}
