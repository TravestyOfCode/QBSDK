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
    [System.Xml.Serialization.XmlTypeAttribute("PurchaseOrderLineGroupMod", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("PurchaseOrderLineGroupMod", Namespace="")]
    public partial class PurchaseOrderLineGroupMod
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TxnLineID")]
        public PurchaseOrderLineGroupModTxnLineID TxnLineID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemGroupRef")]
        public ItemGroupRef ItemGroupRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public string Quantity { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(31)]
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OverrideUOMSetRef")]
        public OverrideUOMSetRef OverrideUOMSetRef { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PurchaseOrderLineMod> _purchaseOrderLineMod;
        
        [System.Xml.Serialization.XmlElementAttribute("PurchaseOrderLineMod")]
        public System.Collections.ObjectModel.Collection<PurchaseOrderLineMod> PurchaseOrderLineMod
        {
            get
            {
                return _purchaseOrderLineMod;
            }
            private set
            {
                _purchaseOrderLineMod = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurchaseOrderLineModSpecified
        {
            get
            {
                return (this.PurchaseOrderLineMod.Count != 0);
            }
        }
        
        public PurchaseOrderLineGroupMod()
        {
            this._purchaseOrderLineMod = new System.Collections.ObjectModel.Collection<PurchaseOrderLineMod>();
        }
    }
}