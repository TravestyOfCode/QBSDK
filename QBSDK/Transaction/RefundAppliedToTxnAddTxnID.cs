using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("RefundAppliedToTxnAddTxnID", Namespace="")]
    public class RefundAppliedToTxnAddTxnID
    {        
        [MaxLength(36)]
        [XmlText()]
        public string Value { get; set; }
        
        [XmlAttribute("useMacro")]
        public string UseMacro { get; set; }
    }
}
