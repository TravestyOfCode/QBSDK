using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ClassRef", Namespace="", AnonymousType=true)]
    [XmlRoot("ClassRef", Namespace="")]
    public partial class ClassRef : IListRef
    {        
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }
        
        [MaxLength(159)]
        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
