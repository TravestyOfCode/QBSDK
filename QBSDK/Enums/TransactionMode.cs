using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("TransactionMode", Namespace="", AnonymousType=true)]
    [XmlRoot("TransactionMode", Namespace="")]
    public enum TransactionMode
    {        
        CardNotPresent,
        
        CardPresent,
    }
}
