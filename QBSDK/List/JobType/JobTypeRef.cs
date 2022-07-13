using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("JobTypeRef", Namespace="", AnonymousType=true)]
    [XmlRoot("JobTypeRef", Namespace="")]
    public class JobTypeRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(159)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
