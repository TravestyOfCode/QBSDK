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
    [System.Xml.Serialization.XmlTypeAttribute("CreditMemoMod", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("CreditMemoMod", Namespace="")]
    public partial class CreditMemoMod : ITxnCoreMod
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TxnID")]
        public string TxnID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(16)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("EditSequence")]
        public string EditSequence { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerRef")]
        public CustomerRef CustomerRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ClassRef")]
        public ClassRef ClassRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ARAccountRef")]
        public ARAccountRef ARAccountRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TemplateRef")]
        public TemplateRef TemplateRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TxnDate")]
        public string TxnDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(11)]
        [System.Xml.Serialization.XmlElementAttribute("RefNumber")]
        public string RefNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BillAddress")]
        public BillAddress BillAddress { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipAddress")]
        public ShipAddress ShipAddress { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsPending")]
        public string IsPending { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
        [System.Xml.Serialization.XmlElementAttribute("PONumber")]
        public string PONumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TermsRef")]
        public TermsRef TermsRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DueDate")]
        public string DueDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SalesRepRef")]
        public SalesRepRef SalesRepRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(13)]
        [System.Xml.Serialization.XmlElementAttribute("FOB")]
        public string FOB { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipDate")]
        public string ShipDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipMethodRef")]
        public ShipMethodRef ShipMethodRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemSalesTaxRef")]
        public ItemSalesTaxRef ItemSalesTaxRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Memo")]
        public string Memo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerMsgRef")]
        public CustomerMsgRef CustomerMsgRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsToBePrinted")]
        public string IsToBePrinted { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsToBeEmailed")]
        public string IsToBeEmailed { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsTaxIncluded")]
        public string IsTaxIncluded { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerSalesTaxCodeRef")]
        public CustomerSalesTaxCodeRef CustomerSalesTaxCodeRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(29)]
        [System.Xml.Serialization.XmlElementAttribute("Other")]
        public string Other { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate")]
        public string ExchangeRate { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CreditMemoLineMod> _creditMemoLineMod;
        
        [System.Xml.Serialization.XmlElementAttribute("CreditMemoLineMod")]
        public System.Collections.ObjectModel.Collection<CreditMemoLineMod> CreditMemoLineMod
        {
            get
            {
                return _creditMemoLineMod;
            }
            private set
            {
                _creditMemoLineMod = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditMemoLineModSpecified
        {
            get
            {
                return (this.CreditMemoLineMod.Count != 0);
            }
        }
        
        public CreditMemoMod()
        {
            this._creditMemoLineMod = new System.Collections.ObjectModel.Collection<CreditMemoLineMod>();
            this._creditMemoLineGroupMod = new System.Collections.ObjectModel.Collection<CreditMemoLineGroupMod>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CreditMemoLineGroupMod> _creditMemoLineGroupMod;
        
        [System.Xml.Serialization.XmlElementAttribute("CreditMemoLineGroupMod")]
        public System.Collections.ObjectModel.Collection<CreditMemoLineGroupMod> CreditMemoLineGroupMod
        {
            get
            {
                return _creditMemoLineGroupMod;
            }
            private set
            {
                _creditMemoLineGroupMod = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditMemoLineGroupModSpecified
        {
            get
            {
                return (this.CreditMemoLineGroupMod.Count != 0);
            }
        }
    }
}