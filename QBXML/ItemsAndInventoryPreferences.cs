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
    [System.Xml.Serialization.XmlTypeAttribute("ItemsAndInventoryPreferences", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ItemsAndInventoryPreferences", Namespace="")]
    public partial class ItemsAndInventoryPreferences
    {
        
        [System.Xml.Serialization.XmlElementAttribute("EnhancedInventoryReceivingEnabled")]
        public string EnhancedInventoryReceivingEnabled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsTrackingSerialOrLotNumber")]
        public IsTrackingSerialOrLotNumber IsTrackingSerialOrLotNumber { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTrackingSerialOrLotNumberSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("isTrackingOnSalesTransactionsEnabled")]
        public string IsTrackingOnSalesTransactionsEnabled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("isTrackingOnPurchaseTransactionsEnabled")]
        public string IsTrackingOnPurchaseTransactionsEnabled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("isTrackingOnInventoryAdjustmentEnabled")]
        public string IsTrackingOnInventoryAdjustmentEnabled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("isTrackingOnBuildAssemblyEnabled")]
        public string IsTrackingOnBuildAssemblyEnabled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("FIFOEnabled")]
        public string FIFOEnabled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("FIFOEffectiveDate")]
        public string FIFOEffectiveDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsRSBEnabled")]
        public string IsRSBEnabled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsBarcodeEnabled")]
        public string IsBarcodeEnabled { get; set; }
    }
}