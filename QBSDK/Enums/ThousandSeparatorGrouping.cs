using System;
using System.Xml.Serialization;

namespace QBSDK
{   
    [Serializable()]
    [XmlType("ThousandSeparatorGrouping", Namespace="", AnonymousType=true)]
    [XmlRoot("ThousandSeparatorGrouping", Namespace="")]
    public enum ThousandSeparatorGrouping
    {        
        XX_XXX_XXX,
        
        X_XX_XX_XXX,
    }
}
