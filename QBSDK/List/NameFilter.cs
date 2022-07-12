using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("NameFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("NameFilter", Namespace="")]
    public class NameFilter
    {        
        [Required()]
        [XmlElement("MatchCriterion")]
        public MatchCriterion MatchCriterion { get; set; }
        
        [Required()]
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
