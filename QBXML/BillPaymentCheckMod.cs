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
    [System.Xml.Serialization.XmlTypeAttribute("BillPaymentCheckMod", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("BillPaymentCheckMod", Namespace="")]
    public partial class BillPaymentCheckMod : ITxnCoreMod
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TxnID")]
        public string TxnID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(16)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("EditSequence")]
        public string EditSequence { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TxnDate")]
        public string TxnDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BankAccountRef")]
        public BankAccountRef BankAccountRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Amount")]
        public string Amount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate")]
        public string ExchangeRate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsToBePrinted")]
        public string IsToBePrinted { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(11)]
        [System.Xml.Serialization.XmlElementAttribute("RefNumber")]
        public string RefNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Memo")]
        public string Memo { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AppliedToTxnMod> _appliedToTxnMod;
        
        [System.Xml.Serialization.XmlElementAttribute("AppliedToTxnMod")]
        public System.Collections.ObjectModel.Collection<AppliedToTxnMod> AppliedToTxnMod
        {
            get
            {
                return _appliedToTxnMod;
            }
            private set
            {
                _appliedToTxnMod = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AppliedToTxnModSpecified
        {
            get
            {
                return (this.AppliedToTxnMod.Count != 0);
            }
        }
        
        public BillPaymentCheckMod()
        {
            this._appliedToTxnMod = new System.Collections.ObjectModel.Collection<AppliedToTxnMod>();
        }
    }
}