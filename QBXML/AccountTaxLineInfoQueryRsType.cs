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
    [System.Xml.Serialization.XmlTypeAttribute("AccountTaxLineInfoQueryRsType", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AccountTaxLineInfoQueryRsType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<global::QBXML.AccountTaxLineInfoRet> _accountTaxLineInfoRet;
        
        [System.Xml.Serialization.XmlElementAttribute("AccountTaxLineInfoRet")]
        public System.Collections.ObjectModel.Collection<global::QBXML.AccountTaxLineInfoRet> AccountTaxLineInfoRet
        {
            get
            {
                return _accountTaxLineInfoRet;
            }
            private set
            {
                _accountTaxLineInfoRet = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountTaxLineInfoRetSpecified
        {
            get
            {
                return (this.AccountTaxLineInfoRet.Count != 0);
            }
        }
        
        public AccountTaxLineInfoQueryRsType()
        {
            this._accountTaxLineInfoRet = new System.Collections.ObjectModel.Collection<global::QBXML.AccountTaxLineInfoRet>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("requestID")]
        public string RequestID { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("statusCode")]
        public string StatusCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("statusSeverity")]
        public string StatusSeverity { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("statusMessage")]
        public string StatusMessage { get; set; }
    }
}