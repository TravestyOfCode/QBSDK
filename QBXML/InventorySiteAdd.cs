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
    [System.Xml.Serialization.XmlTypeAttribute("InventorySiteAdd", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("InventorySiteAdd", Namespace="")]
    public partial class InventorySiteAdd
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(31)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public string Name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsActive")]
        public string IsActive { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ParentSiteRef")]
        public ParentSiteRef ParentSiteRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
        [System.Xml.Serialization.XmlElementAttribute("SiteDesc")]
        public string SiteDesc { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(41)]
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public string Contact { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(21)]
        [System.Xml.Serialization.XmlElementAttribute("Phone")]
        public string Phone { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(21)]
        [System.Xml.Serialization.XmlElementAttribute("Fax")]
        public string Fax { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(1023)]
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public string Email { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SiteAddress")]
        public SiteAddress SiteAddress { get; set; }
    }
}