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
    [System.Xml.Serialization.XmlTypeAttribute("ListEventSubscription", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ListEventSubscription", Namespace="")]
    public partial class ListEventSubscription
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ListEventType> _listEventType;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ListEventType")]
        public System.Collections.ObjectModel.Collection<ListEventType> ListEventType
        {
            get
            {
                return _listEventType;
            }
            private set
            {
                _listEventType = value;
            }
        }
        
        public ListEventSubscription()
        {
            this._listEventType = new System.Collections.ObjectModel.Collection<ListEventType>();
            this._listEventOperation = new System.Collections.ObjectModel.Collection<ListEventOperation>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ListEventOperation> _listEventOperation;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ListEventOperation")]
        public System.Collections.ObjectModel.Collection<ListEventOperation> ListEventOperation
        {
            get
            {
                return _listEventOperation;
            }
            private set
            {
                _listEventOperation = value;
            }
        }
    }
}