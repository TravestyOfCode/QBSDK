using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("SalesTaxCodeRef", Namespace="", AnonymousType=true)]
    [XmlRoot("SalesTaxCodeRef", Namespace="")]
    public class SalesTaxCodeRef : IListRef
    {   
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(3)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
