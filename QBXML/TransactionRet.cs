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
    [System.Xml.Serialization.XmlTypeAttribute("TransactionRet", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TransactionRet", Namespace="")]
    public partial class TransactionRet
    {
        
        [System.Xml.Serialization.XmlElementAttribute("TxnType")]
        public TxnType TxnType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TxnTypeSpecified { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("TxnID")]
        public string TxnID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("TxnLineID")]
        public string TxnLineID { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TimeCreated")]
        public string TimeCreated { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TimeModified")]
        public string TimeModified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("EntityRef")]
        public EntityRef EntityRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AccountRef")]
        public AccountRef AccountRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TxnDate")]
        public string TxnDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("RefNumber")]
        public string RefNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Amount")]
        public string Amount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate")]
        public string ExchangeRate { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("AmountInHomeCurrency")]
        public string AmountInHomeCurrency { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Memo")]
        public string Memo { get; set; }
    }
}