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
    [System.Xml.Serialization.XmlTypeAttribute("ItemSitesQueryRqType", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ItemSitesQueryRqType : global::QBXML.IItemSitesQuery
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
        
        public ItemSitesQueryRqType()
        {
            this._listID = new System.Collections.ObjectModel.Collection<string>();
            this._includeRetElement = new System.Collections.ObjectModel.Collection<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemTypeFilter")]
        public global::QBXML.ItemTypeFilter ItemTypeFilter { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemTypeFilterSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemSiteFilter")]
        public global::QBXML.ItemSiteFilter ItemSiteFilter { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("MaxReturned")]
        public string MaxReturned { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ActiveStatus")]
        public global::QBXML.ActiveStatus ActiveStatus { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActiveStatusSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _includeRetElement;
        
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
        private ItemSitesQueryRqTypeMetaData _metaData = global::QBXML.ItemSitesQueryRqTypeMetaData.NoMetaData;
        
        [System.ComponentModel.DefaultValueAttribute(global::QBXML.ItemSitesQueryRqTypeMetaData.NoMetaData)]
        [System.Xml.Serialization.XmlAttributeAttribute("metaData")]
        public ItemSitesQueryRqTypeMetaData MetaData
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
        
        [System.Xml.Serialization.XmlAttributeAttribute("iterator")]
        public ItemSitesQueryRqTypeIterator Iterator { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IteratorSpecified { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("iteratorID")]
        public string IteratorID { get; set; }
    }
}