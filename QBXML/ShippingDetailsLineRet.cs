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
    [System.Xml.Serialization.XmlTypeAttribute("ShippingDetailsLineRet", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ShippingDetailsLineRet", Namespace="")]
    public partial class ShippingDetailsLineRet
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("TrackingID")]
        public string TrackingID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CarrierName")]
        public string CarrierName { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShippingMethod")]
        public string ShippingMethod { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("ShippingCharges")]
        public string ShippingCharges { get; set; }
    }
}