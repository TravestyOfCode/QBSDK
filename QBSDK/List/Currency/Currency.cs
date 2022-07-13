using Mapster;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("CurrencyRet", Namespace = "", AnonymousType = true)]
    [XmlRoot("CurrencyRet", Namespace = "")]
    public class Currency : IQBEntity
    {
        public Type AddType { get; init; } = typeof(CurrencyAdd);

        public Type ModType { get; init; } = typeof(CurrencyMod);

        public Type DelType { get; init; } = typeof(CurrencyDel);

        [MaxLength(36)]
        [XmlElement("ListID")]
        public string ListID { get; set; }

        [XmlElement("TimeCreated")]
        public DateTime? TimeCreated { get; set; }

        [XmlIgnore()]
        public bool TimeCreatedSpecified => TimeCreated.HasValue;

        [XmlElement("TimeModified")]
        public DateTime? TimeModified { get; set; }

        [XmlIgnore()]
        public bool TimeModifiedSpecified => TimeModified.HasValue;

        [MaxLength(16)]
        [XmlElement("EditSequence")]
        public string EditSequence { get; set; }

        [MaxLength(64)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("IsActive")]
        internal string IsActiveString
        {
            get => IsActive == null ? null : (IsActive.Value ? "true" : "false");
            set => IsActive = value == null ? null : value == "true" ? true : false;
        }

        [XmlIgnore()]
        public bool? IsActive { get; set; }

        [MaxLength(3)]
        [XmlElement("CurrencyCode")]
        public string CurrencyCode { get; set; }

        [XmlElement("CurrencyFormat")]
        public CurrencyFormat CurrencyFormat { get; set; }

        [XmlElement("IsUserDefinedCurrency")]
        public string IsUserDefinedCurrency { get; set; }

        [XmlElement("ExchangeRate")]
        public float ExchangeRate { get; set; }

        [XmlElement("AsOfDate")]
        public DateTime? AsOfDate { get; set; }

        [XmlIgnore()]
        public bool AsOfDateSpecified => AsOfDate.HasValue;

        public Currency()
        {

        }

        public static implicit operator CurrencyAdd(Currency currency) => currency.Adapt<CurrencyAdd>();

        public static implicit operator CurrencyMod(Currency currency) => currency.Adapt<CurrencyMod>();

        public static implicit operator CurrencyDel(Currency currency) => currency.Adapt<CurrencyDel>();
    }
}
