using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CashFlowClassification", Namespace="", AnonymousType=true)]
    [XmlRoot("CashFlowClassification", Namespace="")]
    public enum CashFlowClassification
    {        
        None,
        
        Operating,
        
        Investing,
        
        Financing,
        
        NotApplicable,
    }
}
