using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlRoot("ARRefundCreditCardQueryRq", Namespace = "")]
    public class ARRefundCreditCardQueryRq : Request<ARRefundCreditCardQueryRq>//, IXmlSerializable
    {
        [XmlIgnore()]
        private Collection<string> _txnID;

        [MaxLength(36)]
        [XmlElement("TxnID")]
        public Collection<string> TxnID
        {
            get => _txnID;
            private set => _txnID = value;
        }

        [XmlIgnore()]
        public bool TxnIDSpecified => TxnID.Count != 0;

        [XmlIgnore()]
        private Collection<string> _refNumber;

        [XmlElement("RefNumber")]
        public Collection<string> RefNumber
        {
            get => _refNumber;
            private set => _refNumber = value;
        }

        [XmlIgnore()]
        public bool RefNumberSpecified => RefNumber.Count != 0;

        [XmlIgnore()]
        private Collection<string> _refNumberCaseSensitive;

        [XmlElement("RefNumberCaseSensitive")]
        public Collection<string> RefNumberCaseSensitive
        {
            get => _refNumberCaseSensitive;
            private set => _refNumberCaseSensitive = value;
        }

        [XmlIgnore()]
        public bool RefNumberCaseSensitiveSpecified => RefNumberCaseSensitive.Count != 0;

        [XmlElement("MaxReturned")]
        public int? MaxReturned { get; set; }

        [XmlIgnore()]
        public bool MaxReturnedSpecified => MaxReturned.HasValue;

        [XmlElement("ModifiedDateRangeFilter")]
        public ModifiedDateRangeFilter ModifiedDateRangeFilter { get; set; }

        [XmlElement("TxnDateRangeFilter")]
        public TxnDateRangeFilter TxnDateRangeFilter { get; set; }

        [XmlElement("EntityFilter")]
        public EntityFilter EntityFilter { get; set; }

        [XmlElement("AccountFilter")]
        public AccountFilter AccountFilter { get; set; }

        [XmlElement("RefNumberFilter")]
        public RefNumberFilter RefNumberFilter { get; set; }

        [XmlElement("RefNumberRangeFilter")]
        public RefNumberRangeFilter RefNumberRangeFilter { get; set; }

        [XmlElement("CurrencyFilter")]
        public CurrencyFilter CurrencyFilter { get; set; }

        [XmlIgnore()]
        public bool? IncludeLineItems { get; set; }

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

        [XmlIgnore()]
        private Collection<string> _ownerID;

        [RegularExpression("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [XmlElement("OwnerID")]
        public Collection<string> OwnerID
        {
            get => _ownerID;
            private set => _ownerID = value;
        }

        [XmlIgnore()]
        public bool OwnerIDSpecified => OwnerID.Count != 0;

        [XmlIgnore()]
        public MetaData? MetaData { get; set; }

        [XmlAttribute("metaData")]
        public string MetaDataString
        {
            get => MetaData?.ToString();
            set
            {
                if(value == null)
                {
                    MetaData = null;
                    return;
                }
                MetaData = Enum.Parse<MetaData>(value, true);
            }
        }

        [XmlIgnore()]
        public Iterator? Iterator { get; set; }

        [XmlAttribute("iterator")]
        public string IteratorString
        {
            get => Iterator?.ToString();
            set
            {
                if(value == null)
                {
                    Iterator = null;
                    return;
                }
                Iterator = Enum.Parse<Iterator>(value, true);
            }
        }

        [XmlAttribute("iteratorID")]
        public string IteratorID { get; set; }

        public ARRefundCreditCardQueryRq()
        {
            _txnID = new Collection<string>();
            _refNumber = new Collection<string>();
            _refNumberCaseSensitive = new Collection<string>();
            _includeRetElement = new Collection<string>();
            _ownerID = new Collection<string>();
        }        
    }
}
