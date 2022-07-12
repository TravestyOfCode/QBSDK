using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AVSZip", Namespace="", AnonymousType=true)]
    [XmlRoot("AVSZip", Namespace="")]
    public enum AVSZip
    {        
        Pass,
        
        Fail,
        
        NotAvailable,
    }
}
