using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("DeliveryMethod", Namespace="", AnonymousType=true)]
    [XmlRoot("DeliveryMethod", Namespace="")]
    public enum DeliveryMethod
    {        
        Email,
        
        Fax,
        
        Print,
    }
}
