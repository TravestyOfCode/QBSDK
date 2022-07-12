using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ActiveStatus", Namespace="", AnonymousType=true)]
    [XmlRoot("ActiveStatus", Namespace="")]
    public enum ActiveStatus
    {        
        ActiveOnly,
        
        InactiveOnly,
        
        All,
    }
}
