using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ParentRef", Namespace = "", AnonymousType = true)]
    [XmlRoot("ParentRef", Namespace = "")]
    public partial class ParentRef : IListRef
    {
        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }

        [XmlElement("FullName")]
        public string FullName { get; set; }
    }
}
