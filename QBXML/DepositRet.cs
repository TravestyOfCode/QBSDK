//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.718.0 using the following command:
// XmlSchemaClassGenerator -v -n =QBXML -o "C:\Program Files\Intuit\IDN\Common\tools\validator" --sf -dc --dst --da -gc "C:\Program Files\Intuit\IDN\Common\tools\validator\qbxmlops150.xsd"
namespace QBXML
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.718.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DepositRet", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DepositRet", Namespace="")]
    public partial class DepositRet : ITxnCore
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("TxnID")]
        public string TxnID { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TimeCreated")]
        public string TimeCreated { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TimeModified")]
        public string TimeModified { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(16)]
        [System.Xml.Serialization.XmlElementAttribute("EditSequence")]
        public string EditSequence { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TxnNumber")]
        public string TxnNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TxnDate")]
        public string TxnDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DepositToAccountRef")]
        public DepositToAccountRef DepositToAccountRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Memo")]
        public string Memo { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("DepositTotal")]
        public string DepositTotal { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate")]
        public string ExchangeRate { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("DepositTotalInHomeCurrency")]
        public string DepositTotalInHomeCurrency { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CashBackInfoRet")]
        public CashBackInfoRet CashBackInfoRet { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [System.Xml.Serialization.XmlElementAttribute("ExternalGUID")]
        public string ExternalGUID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DepositLineRet> _depositLineRet;
        
        [System.Xml.Serialization.XmlElementAttribute("DepositLineRet")]
        public System.Collections.ObjectModel.Collection<DepositLineRet> DepositLineRet
        {
            get
            {
                return _depositLineRet;
            }
            private set
            {
                _depositLineRet = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepositLineRetSpecified
        {
            get
            {
                return (this.DepositLineRet.Count != 0);
            }
        }
        
        public DepositRet()
        {
            this._depositLineRet = new System.Collections.ObjectModel.Collection<DepositLineRet>();
            this._dataExtRet = new System.Collections.ObjectModel.Collection<DataExtRet>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataExtRet> _dataExtRet;
        
        [System.Xml.Serialization.XmlElementAttribute("DataExtRet")]
        public System.Collections.ObjectModel.Collection<DataExtRet> DataExtRet
        {
            get
            {
                return _dataExtRet;
            }
            private set
            {
                _dataExtRet = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataExtRetSpecified
        {
            get
            {
                return (this.DataExtRet.Count != 0);
            }
        }
    }
}