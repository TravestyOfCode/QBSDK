using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ListDelRqType", Namespace = "")]
    public class AccountDel
    {
        [Required()]
        [XmlElement("ListDelType")]
        public ListDelType ListDelType { get; init; } = ListDelType.Account;

        [MaxLength(36)]
        [Required()]
        [XmlElement("ListID")]
        public string ListID { get; set; }

        [XmlAttribute("requestID")]
        public string RequestID { get; set; }
    }
}
