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
    [System.Xml.Serialization.XmlTypeAttribute("EmployeeAdd", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("EmployeeAdd", Namespace="")]
    public partial class EmployeeAdd : IPersonName
    {
        
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public string Name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IsActive")]
        public string IsActive { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(15)]
        [System.Xml.Serialization.XmlElementAttribute("Salutation")]
        public string Salutation { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
        [System.Xml.Serialization.XmlElementAttribute("FirstName")]
        public string FirstName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(5)]
        [System.Xml.Serialization.XmlElementAttribute("MiddleName")]
        public string MiddleName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
        [System.Xml.Serialization.XmlElementAttribute("LastName")]
        public string LastName { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Suffix")]
        public string Suffix { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(41)]
        [System.Xml.Serialization.XmlElementAttribute("JobTitle")]
        public string JobTitle { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SupervisorRef")]
        public SupervisorRef SupervisorRef { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(31)]
        [System.Xml.Serialization.XmlElementAttribute("Department")]
        public string Department { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(64)]
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public string Description { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([+\\-]?[0-9]{1,13}(\\.[0-9]{2})?)?")]
        [System.Xml.Serialization.XmlElementAttribute("TargetBonus")]
        public string TargetBonus { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("EmployeeAddress")]
        public EmployeeAddress EmployeeAddress { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(41)]
        [System.Xml.Serialization.XmlElementAttribute("PrintAs")]
        public string PrintAs { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(21)]
        [System.Xml.Serialization.XmlElementAttribute("Phone")]
        public string Phone { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(21)]
        [System.Xml.Serialization.XmlElementAttribute("Mobile")]
        public string Mobile { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(21)]
        [System.Xml.Serialization.XmlElementAttribute("Pager")]
        public string Pager { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.Xml.Serialization.XmlElementAttribute("PagerPIN")]
        public string PagerPIN { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(21)]
        [System.Xml.Serialization.XmlElementAttribute("AltPhone")]
        public string AltPhone { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(21)]
        [System.Xml.Serialization.XmlElementAttribute("Fax")]
        public string Fax { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(15)]
        [System.Xml.Serialization.XmlElementAttribute("SSN")]
        public string SSN { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(1023)]
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public string Email { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AdditionalContactRef> _additionalContactRef;
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalContactRef")]
        public System.Collections.ObjectModel.Collection<AdditionalContactRef> AdditionalContactRef
        {
            get
            {
                return _additionalContactRef;
            }
            private set
            {
                _additionalContactRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalContactRefSpecified
        {
            get
            {
                return (this.AdditionalContactRef.Count != 0);
            }
        }
        
        public EmployeeAdd()
        {
            this._additionalContactRef = new System.Collections.ObjectModel.Collection<AdditionalContactRef>();
            this._additionalNotes = new System.Collections.ObjectModel.Collection<AdditionalNotes>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EmergencyContacts")]
        public EmergencyContacts EmergencyContacts { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("EmployeeType")]
        public EmployeeType EmployeeType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmployeeTypeSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PartOrFullTime")]
        public PartOrFullTime PartOrFullTime { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PartOrFullTimeSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Exempt")]
        public Exempt Exempt { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExemptSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("KeyEmployee")]
        public KeyEmployee KeyEmployee { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KeyEmployeeSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Gender")]
        public Gender Gender { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("HiredDate")]
        public string HiredDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OriginalHireDate")]
        public string OriginalHireDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AdjustedServiceDate")]
        public string AdjustedServiceDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReleasedDate")]
        public string ReleasedDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BirthDate")]
        public string BirthDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("USCitizen")]
        public USCitizen USCitizen { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool USCitizenSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Ethnicity")]
        public Ethnicity Ethnicity { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EthnicitySpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Disabled")]
        public Disabled Disabled { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisabledSpecified { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
        [System.Xml.Serialization.XmlElementAttribute("DisabilityDesc")]
        public string DisabilityDesc { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OnFile")]
        public OnFile OnFile { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnFileSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("WorkAuthExpireDate")]
        public string WorkAuthExpireDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("USVeteran")]
        public USVeteran USVeteran { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool USVeteranSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("MilitaryStatus")]
        public MilitaryStatus MilitaryStatus { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MilitaryStatusSpecified { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(99)]
        [System.Xml.Serialization.XmlElementAttribute("AccountNumber")]
        public string AccountNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4095)]
        [System.Xml.Serialization.XmlElementAttribute("Notes")]
        public string Notes { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AdditionalNotes> _additionalNotes;
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalNotes")]
        public System.Collections.ObjectModel.Collection<AdditionalNotes> AdditionalNotes
        {
            get
            {
                return _additionalNotes;
            }
            private set
            {
                _additionalNotes = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalNotesSpecified
        {
            get
            {
                return (this.AdditionalNotes.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BillingRateRef")]
        public BillingRateRef BillingRateRef { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("EmployeePayrollInfo")]
        public EmployeePayrollInfo EmployeePayrollInfo { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [System.Xml.Serialization.XmlElementAttribute("ExternalGUID")]
        public string ExternalGUID { get; set; }
    }
}