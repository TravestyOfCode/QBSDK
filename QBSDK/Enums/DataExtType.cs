using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("DataExtType", Namespace="", AnonymousType=true)]
    [XmlRoot("DataExtType", Namespace="")]
    public enum DataExtType
    {        
        AMTTYPE,
        
        DATETIMETYPE,
        
        INTTYPE,
        
        PERCENTTYPE,
        
        PRICETYPE,
        
        QUANTYPE,
        
        STR1024TYPE,
        
        STR255TYPE,
    }
}
