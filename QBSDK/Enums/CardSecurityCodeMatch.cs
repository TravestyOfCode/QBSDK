using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CardSecurityCodeMatch", Namespace="", AnonymousType=true)]
    [XmlRoot("CardSecurityCodeMatch", Namespace="")]
    public enum CardSecurityCodeMatch
    {        
        Pass,
        
        Fail,
        
        NotAvailable,
    }
}
