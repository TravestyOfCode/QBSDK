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
    [System.Xml.Serialization.XmlTypeAttribute("PurchaseOrderLineRet", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("PurchaseOrderLineRet", Namespace="")]
    public partial class PurchaseOrderLineRet
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TxnLineID")]
        public string TxnLineID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemRef")]
        public ItemRef ItemRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(31)]
        [System.Xml.Serialization.XmlElementAttribute("ManufacturerPartNumber")]
        public string ManufacturerPartNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Desc")]
        public string Desc { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public string Quantity { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(31)]
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OverrideUOMSetRef")]
        public OverrideUOMSetRef OverrideUOMSetRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Rate")]
        public string Rate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ClassRef")]
        public ClassRef ClassRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Amount")]
        public string Amount { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TaxAmount")]
        public string TaxAmount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("InventorySiteLocationRef")]
        public InventorySiteLocationRef InventorySiteLocationRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerRef")]
        public CustomerRef CustomerRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ServiceDate")]
        public string ServiceDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SalesTaxCodeRef")]
        public SalesTaxCodeRef SalesTaxCodeRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("ReceivedQuantity")]
        public string ReceivedQuantity { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("UnbilledQuantity")]
        public string UnbilledQuantity { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsBilled")]
        public string IsBilled { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsManuallyClosed")]
        public string IsManuallyClosed { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(29)]
        [System.Xml.Serialization.XmlElementAttribute("Other1")]
        public string Other1 { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(29)]
        [System.Xml.Serialization.XmlElementAttribute("Other2")]
        public string Other2 { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataExtRet> _dataExtRet;
        
        [System.Xml.Serialization.XmlElementAttribute("DataExtRet")]
        public System.Collections.ObjectModel.Collection<DataExtRet> DataExtRet
        {
            get
            {
                return _dataExtRet;
            }
            private set
            {
                _dataExtRet = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataExtRetSpecified
        {
            get
            {
                return (this.DataExtRet.Count != 0);
            }
        }
        
        public PurchaseOrderLineRet()
        {
            this._dataExtRet = new System.Collections.ObjectModel.Collection<DataExtRet>();
        }
    }
}