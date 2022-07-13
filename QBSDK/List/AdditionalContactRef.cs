using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AdditionalContactRef", Namespace="", AnonymousType=true)]
    [XmlRoot("AdditionalContactRef", Namespace="")]
    public class AdditionalContactRef
    {        
        [MaxLength(40)]
        [Required()]
        [XmlElement("ContactName")]
        public string ContactName { get; set; }
        
        [MaxLength(255)]
        [Required()]
        [XmlElement("ContactValue")]
        public string ContactValue { get; set; }
    }
}
