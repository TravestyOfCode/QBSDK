using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CurrencyRef", Namespace="", AnonymousType=true)]
    [XmlRoot("CurrencyRef", Namespace="")]
    public class CurrencyRef : IListRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(64)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
