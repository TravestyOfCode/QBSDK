using System;
using System.Xml;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("TxnDateRangeFilter", Namespace="", AnonymousType=true)]
    [XmlRoot("TxnDateRangeFilter", Namespace="")]
    public class TxnDateRangeFilter
    {        
        [XmlElement("FromTxnDate")]
        public DateTime? FromTxnDate { get; set; }

        [XmlIgnore()]
        public bool FromTxnDateSpecified => FromTxnDate.HasValue;

        [XmlElement("ToTxnDate")]
        public DateTime? ToTxnDate { get; set; }

        [XmlIgnore()]
        public bool ToTxnDateSpecified => ToTxnDate.HasValue;

        [XmlElement("DateMacro")]
        public DateMacro? DateMacro { get; set; }

        [XmlIgnore()]
        public bool DateMacroSpecified => DateMacro.HasValue;

        public TxnDateRangeFilter()
        {

        }

        public TxnDateRangeFilter(DateMacro dateMacro)
        {
            DateMacro = dateMacro;
        }

        public TxnDateRangeFilter(DateTime fromTxnDate, DateTime toTxnDate)
        {
            FromTxnDate = fromTxnDate;
            ToTxnDate = toTxnDate;
        }        
    }
}
