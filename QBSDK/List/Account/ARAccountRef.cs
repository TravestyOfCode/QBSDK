using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ARAccountRef", Namespace="", AnonymousType=true)]
    [XmlRoot("ARAccountRef", Namespace="")]
    public class ARAccountRef 
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(159)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
