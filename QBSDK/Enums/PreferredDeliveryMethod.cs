using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("PreferredDeliveryMethod", Namespace="", AnonymousType=true)]
    [XmlRoot("PreferredDeliveryMethod", Namespace="")]
    public enum PreferredDeliveryMethod
    {        
        None,
        
        Email,
        
        Fax,
    }
}
