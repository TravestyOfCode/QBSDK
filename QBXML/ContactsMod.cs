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
    [System.Xml.Serialization.XmlTypeAttribute("ContactsMod", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ContactsMod", Namespace="")]
    public partial class ContactsMod : IContactInfo
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("ListID")]
        public string ListID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(16)]
        [System.Xml.Serialization.XmlElementAttribute("EditSequence")]
        public string EditSequence { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(15)]
        [System.Xml.Serialization.XmlElementAttribute("Salutation")]
        public string Salutation { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("FirstName")]
        public string FirstName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(5)]
        [System.Xml.Serialization.XmlElementAttribute("MiddleName")]
        public string MiddleName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
        [System.Xml.Serialization.XmlElementAttribute("LastName")]
        public string LastName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(41)]
        [System.Xml.Serialization.XmlElementAttribute("JobTitle")]
        public string JobTitle { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AdditionalContactRef> _additionalContactRef;
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalContactRef")]
        public System.Collections.ObjectModel.Collection<AdditionalContactRef> AdditionalContactRef
        {
            get
            {
                return _additionalContactRef;
            }
            private set
            {
                _additionalContactRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalContactRefSpecified
        {
            get
            {
                return (this.AdditionalContactRef.Count != 0);
            }
        }
        
        public ContactsMod()
        {
            this._additionalContactRef = new System.Collections.ObjectModel.Collection<AdditionalContactRef>();
        }
    }
}