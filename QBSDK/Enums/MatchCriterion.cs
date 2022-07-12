using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("MatchCriterion", Namespace="", AnonymousType=true)]
    [XmlRoot("MatchCriterion", Namespace="")]
    public enum MatchCriterion
    {   
        StartsWith,
        
        Contains,
        
        EndsWith,
    }
}
