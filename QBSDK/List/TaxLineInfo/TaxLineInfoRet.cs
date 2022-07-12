using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("TaxLineInfoRet", Namespace="", AnonymousType=true)]
    [XmlRoot("TaxLineInfoRet", Namespace="")]
    public partial class TaxLineInfoRet
    {
        
        [Required()]
        [XmlElement("TaxLineID")]
        public int TaxLineID { get; set; }
        
        [MaxLength(256)]
        [XmlElement("TaxLineName")]
        public string TaxLineName { get; set; }
    }
}
