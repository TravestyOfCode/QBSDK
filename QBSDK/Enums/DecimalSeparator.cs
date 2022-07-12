using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("DecimalSeparator", Namespace="", AnonymousType=true)]
    [XmlRoot("DecimalSeparator", Namespace="")]
    public enum DecimalSeparator
    {        
        Period,
        
        Comma,
    }
}
