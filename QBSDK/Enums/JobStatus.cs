using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("JobStatus", Namespace="", AnonymousType=true)]
    [XmlRoot("JobStatus", Namespace="")]
    public enum JobStatus
    {        
        Awarded,
        
        Closed,
        
        InProgress,
        
        None,
        
        NotAwarded,
        
        Pending,
    }
}
