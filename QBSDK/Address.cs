using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("Address", Namespace = "", AnonymousType = true)]
    [XmlRoot("Address", Namespace = "")]
    public class Address : AddressBlock
    {
        [MaxLength(31)]
        [XmlElement("City")]
        public string City { get; set; }

        [MaxLength(21)]
        [XmlElement("State")]
        public string State { get; set; }

        [MaxLength(13)]
        [XmlElement("PostalCode")]
        public string PostalCode { get; set; }

        [MaxLength(31)]
        [XmlElement("Country")]
        public string Country { get; set; }

        [MaxLength(41)]
        [XmlElement("Note")]
        public string Note { get; set; }
    }
}
