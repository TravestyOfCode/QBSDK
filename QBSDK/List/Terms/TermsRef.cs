using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("TermsRef", Namespace="", AnonymousType=true)]
    [XmlRoot("TermsRef", Namespace="")]
    public partial class TermsRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(31)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
