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
    [System.Xml.Serialization.XmlTypeAttribute("StandardTermsQueryRsType", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StandardTermsQueryRsType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<global::QBXML.StandardTermsRet> _standardTermsRet;
        
        [System.Xml.Serialization.XmlElementAttribute("StandardTermsRet")]
        public System.Collections.ObjectModel.Collection<global::QBXML.StandardTermsRet> StandardTermsRet
        {
            get
            {
                return _standardTermsRet;
            }
            private set
            {
                _standardTermsRet = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StandardTermsRetSpecified
        {
            get
            {
                return (this.StandardTermsRet.Count != 0);
            }
        }
        
        public StandardTermsQueryRsType()
        {
            this._standardTermsRet = new System.Collections.ObjectModel.Collection<global::QBXML.StandardTermsRet>();
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
        
        [System.Xml.Serialization.XmlAttributeAttribute("retCount")]
        public string RetCount { get; set; }
    }
}