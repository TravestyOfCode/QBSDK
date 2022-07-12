using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("QBFileMode", Namespace="", AnonymousType=true)]
    [XmlRoot("QBFileMode", Namespace="")]
    public enum QBFileMode
    {        
        MultiUser,
        
        SingleUser,

        DoNotCare,
    }
}
