using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AVSStreet", Namespace="", AnonymousType=true)]
    [XmlRoot("AVSStreet", Namespace="")]
    public enum AVSStreet
    {        
        Pass,
        
        Fail,
        
        NotAvailable,
    }
}
