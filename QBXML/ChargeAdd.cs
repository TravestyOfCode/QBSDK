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
    [System.Xml.Serialization.XmlTypeAttribute("ChargeAdd", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ChargeAdd", Namespace="")]
    public partial class ChargeAdd
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CustomerRef")]
        public CustomerRef CustomerRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TxnDate")]
        public string TxnDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(11)]
        [System.Xml.Serialization.XmlElementAttribute("RefNumber")]
        public string RefNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemRef")]
        public ItemRef ItemRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("InventorySiteRef")]
        public InventorySiteRef InventorySiteRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("InventorySiteLocationRef")]
        public InventorySiteLocationRef InventorySiteLocationRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public string Quantity { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(31)]
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Rate")]
        public string Rate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OptionForPriceRuleConflict")]
        public OptionForPriceRuleConflict OptionForPriceRuleConflict { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptionForPriceRuleConflictSpecified { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Amount")]
        public string Amount { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Desc")]
        public string Desc { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ARAccountRef")]
        public ARAccountRef ARAccountRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ClassRef")]
        public ClassRef ClassRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BilledDate")]
        public string BilledDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DueDate")]
        public string DueDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OverrideItemAccountRef")]
        public OverrideItemAccountRef OverrideItemAccountRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [System.Xml.Serialization.XmlElementAttribute("ExternalGUID")]
        public string ExternalGUID { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("defMacro")]
        public string DefMacro { get; set; }
    }
}