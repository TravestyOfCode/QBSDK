using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("SalesTaxCountry", Namespace="", AnonymousType=true)]
    [XmlRoot("SalesTaxCountry", Namespace="")]
    public enum SalesTaxCountry
    {        
        Australia,
        
        Canada,
        
        UK,
        
        US,
    }
}
