using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("RefNumberFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("RefNumberFilter", Namespace="")]
    public class RefNumberFilter
    {        
        [Required()]
        [XmlElement("MatchCriterion")]
        public MatchCriterion MatchCriterion { get; set; }
        
        [Required()]
        [XmlElement("RefNumber")]
        public string RefNumber { get; set; }

        public RefNumberFilter()
        {

        }

        public RefNumberFilter(string refNumber, MatchCriterion matchCriterion = MatchCriterion.StartsWith)
        {
            RefNumber = refNumber;
            MatchCriterion = MatchCriterion;
        }
    }
}
