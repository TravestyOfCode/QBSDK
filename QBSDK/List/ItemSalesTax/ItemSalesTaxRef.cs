using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ItemSalesTaxRef", Namespace="", AnonymousType=true)]
    [XmlRoot("ItemSalesTaxRef", Namespace="")]
    public class ItemSalesTaxRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(31)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}