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
    [System.Xml.Serialization.XmlTypeAttribute("InventorySiteQueryRqType", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InventorySiteQueryRqType : global::QBXML.IInventorySiteQuery
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _listID;
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlElementAttribute("ListID")]
        public System.Collections.ObjectModel.Collection<string> ListID
        {
            get
            {
                return _listID;
            }
            private set
            {
                _listID = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListIDSpecified
        {
            get
            {
                return (this.ListID.Count != 0);
            }
        }
        
        public InventorySiteQueryRqType()
        {
            this._listID = new System.Collections.ObjectModel.Collection<string>();
            this._fullName = new System.Collections.ObjectModel.Collection<string>();
            this._includeRetElement = new System.Collections.ObjectModel.Collection<string>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _fullName;
        
        [System.Xml.Serialization.XmlElementAttribute("FullName")]
        public System.Collections.ObjectModel.Collection<string> FullName
        {
            get
            {
                return _fullName;
            }
            private set
            {
                _fullName = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FullNameSpecified
        {
            get
            {
                return (this.FullName.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ActiveStatus")]
        public global::QBXML.ActiveStatus ActiveStatus { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActiveStatusSpecified { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("FromModifiedDate")]
        public string FromModifiedDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{4}\\-[0-9]{1,2}\\-[0-9]{1,2}(T[0-9]{1,2}(:[0-9]{1,2}(:[0-9]{1,2}([+\\-]{1}[0-" +
            "9]{1,2}:[0-9]{1,2})?)?)?)?)?")]
        [System.Xml.Serialization.XmlElementAttribute("ToModifiedDate")]
        public string ToModifiedDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("NameFilter")]
        public global::QBXML.NameFilter NameFilter { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("NameRangeFilter")]
        public global::QBXML.NameRangeFilter NameRangeFilter { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _includeRetElement;
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        [System.Xml.Serialization.XmlElementAttribute("IncludeRetElement")]
        public System.Collections.ObjectModel.Collection<string> IncludeRetElement
        {
            get
            {
                return _includeRetElement;
            }
            private set
            {
                _includeRetElement = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeRetElementSpecified
        {
            get
            {
                return (this.IncludeRetElement.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("requestID")]
        public string RequestID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private InventorySiteQueryRqTypeMetaData _metaData = global::QBXML.InventorySiteQueryRqTypeMetaData.NoMetaData;
        
        [System.ComponentModel.DefaultValueAttribute(global::QBXML.InventorySiteQueryRqTypeMetaData.NoMetaData)]
        [System.Xml.Serialization.XmlAttributeAttribute("metaData")]
        public InventorySiteQueryRqTypeMetaData MetaData
        {
            get
            {
                return _metaData;
            }
            set
            {
                _metaData = value;
            }
        }
    }
}