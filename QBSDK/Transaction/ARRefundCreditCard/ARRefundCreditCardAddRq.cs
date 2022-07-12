using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ARRefundCreditCardAddRq", Namespace="")]
    public class ARRefundCreditCardAddRq
    {        
        [Required()]
        [XmlElement("ARRefundCreditCardAdd")]
        public ARRefundCreditCardAdd ARRefundCreditCardAdd { get; set; }
        
        [XmlIgnore()]
        private Collection<string> _includeRetElement;
        
        [MaxLength(50)]
        [XmlElement("IncludeRetElement")]
        public Collection<string> IncludeRetElement
        {
            get => _includeRetElement;
            private set => _includeRetElement = value;
        }

        [XmlIgnore()]
        public bool IncludeRetElementSpecified => IncludeRetElement.Count != 0;
        
        [XmlAttribute("requestID")]
        public string RequestID { get; set; }

        public ARRefundCreditCardAddRq()
        {
            _includeRetElement = new Collection<string>();
        }

    }
}
