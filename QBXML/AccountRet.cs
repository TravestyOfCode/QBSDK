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
    [System.Xml.Serialization.XmlTypeAttribute("AccountRet", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AccountRet", Namespace="")]
    public partial class AccountRet : IListCore
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("ListID")]
        public string ListID { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TimeCreated")]
        public string TimeCreated { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TimeModified")]
        public string TimeModified { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(16)]
        [System.Xml.Serialization.XmlElementAttribute("EditSequence")]
        public string EditSequence { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(31)]
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public string Name { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(159)]
        [System.Xml.Serialization.XmlElementAttribute("FullName")]
        public string FullName { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsActive")]
        public string IsActive { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ParentRef")]
        public ParentRef ParentRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Sublevel")]
        public string Sublevel { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AccountType")]
        public AccountType AccountType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountTypeSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DetailAccountType")]
        public DetailAccountType DetailAccountType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DetailAccountTypeSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SpecialAccountType")]
        public SpecialAccountType SpecialAccountType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpecialAccountTypeSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsTaxAccount")]
        public string IsTaxAccount { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(7)]
        [System.Xml.Serialization.XmlElementAttribute("AccountNumber")]
        public string AccountNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
        [System.Xml.Serialization.XmlElementAttribute("BankNumber")]
        public string BankNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("LastCheckNumber")]
        public string LastCheckNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(200)]
        [System.Xml.Serialization.XmlElementAttribute("Desc")]
        public string Desc { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("Balance")]
        public string Balance { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TotalBalance")]
        public string TotalBalance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SalesTaxCodeRef")]
        public SalesTaxCodeRef SalesTaxCodeRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxLineInfoRet")]
        public TaxLineInfoRet TaxLineInfoRet { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CashFlowClassification")]
        public CashFlowClassification CashFlowClassification { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CashFlowClassificationSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CurrencyRef")]
        public CurrencyRef CurrencyRef { get; set; }
        
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
        
        public AccountRet()
        {
            this._dataExtRet = new System.Collections.ObjectModel.Collection<DataExtRet>();
        }
    }
}