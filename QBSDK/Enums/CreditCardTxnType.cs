using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CreditCardTxnType", Namespace="", AnonymousType=true)]
    [XmlRoot("CreditCardTxnType", Namespace="")]
    public enum CreditCardTxnType
    {        
        Authorization,
        
        Capture,
        
        Charge,
        
        Refund,
        
        VoiceAuthorization,
    }
}
