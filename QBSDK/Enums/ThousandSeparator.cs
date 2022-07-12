using System.Xml.Serialization;

namespace QBSDK
{
    [System.Serializable()]
    [XmlType("ThousandSeparator", Namespace="", AnonymousType=true)]
    [XmlRoot("ThousandSeparator", Namespace = "")]
    public enum ThousandSeparator
    {   
        Comma,
        
        Period,
        
        Space,
        
        Apostrophe,
    }
}
