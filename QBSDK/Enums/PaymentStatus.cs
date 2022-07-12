using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("PaymentStatus", Namespace="", AnonymousType=true)]
    [XmlRoot("PaymentStatus", Namespace="")]
    public enum PaymentStatus
    {        
        Unknown,
        
        Completed,
    }
}
