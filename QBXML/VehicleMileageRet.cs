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
    [System.Xml.Serialization.XmlTypeAttribute("VehicleMileageRet", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("VehicleMileageRet", Namespace="")]
    public partial class VehicleMileageRet
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("TxnID")]
        public string TxnID { get; set; }
        
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
        
        [System.Xml.Serialization.XmlElementAttribute("VehicleRef")]
        public VehicleRef VehicleRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerRef")]
        public CustomerRef CustomerRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemRef")]
        public ItemRef ItemRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ClassRef")]
        public ClassRef ClassRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TripStartDate")]
        public string TripStartDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TripEndDate")]
        public string TripEndDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("OdometerStart")]
        public string OdometerStart { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("OdometerEnd")]
        public string OdometerEnd { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TotalMiles")]
        public string TotalMiles { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Notes")]
        public string Notes { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BillableStatus")]
        public BillableStatus BillableStatus { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillableStatusSpecified { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("StandardMileageRate")]
        public string StandardMileageRate { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("StandardMileageTotalAmount")]
        public string StandardMileageTotalAmount { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,10}(\\.[0-9]{1,5})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("BillableRate")]
        public string BillableRate { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("BillableAmount")]
        public string BillableAmount { get; set; }
    }
}