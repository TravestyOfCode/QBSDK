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
    [System.Xml.Serialization.XmlTypeAttribute("ExpenseLineAdd", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ExpenseLineAdd", Namespace="")]
    public partial class ExpenseLineAdd
    {
        
        [System.Xml.Serialization.XmlElementAttribute("AccountRef")]
        public AccountRef AccountRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Amount")]
        public string Amount { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TaxAmount")]
        public string TaxAmount { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Memo")]
        public string Memo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerRef")]
        public CustomerRef CustomerRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("VendorRef")]
        public VendorRef VendorRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ClassRef")]
        public ClassRef ClassRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SalesTaxCodeRef")]
        public SalesTaxCodeRef SalesTaxCodeRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BillableStatus")]
        public BillableStatus BillableStatus { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillableStatusSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SalesRepRef")]
        public SalesRepRef SalesRepRef { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataExt> _dataExt;
        
        [System.Xml.Serialization.XmlElementAttribute("DataExt")]
        public System.Collections.ObjectModel.Collection<DataExt> DataExt
        {
            get
            {
                return _dataExt;
            }
            private set
            {
                _dataExt = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataExtSpecified
        {
            get
            {
                return (this.DataExt.Count != 0);
            }
        }
        
        public ExpenseLineAdd()
        {
            this._dataExt = new System.Collections.ObjectModel.Collection<DataExt>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("defMacro")]
        public string DefMacro { get; set; }
    }
}