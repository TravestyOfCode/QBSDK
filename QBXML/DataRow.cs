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
    [System.Xml.Serialization.XmlTypeAttribute("DataRow", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DataRow", Namespace="")]
    public partial class DataRow
    {
        
        [System.Xml.Serialization.XmlElementAttribute("RowData")]
        public RowData RowData { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ColData> _colData;
        
        [System.Xml.Serialization.XmlElementAttribute("ColData")]
        public System.Collections.ObjectModel.Collection<ColData> ColData
        {
            get
            {
                return _colData;
            }
            private set
            {
                _colData = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColDataSpecified
        {
            get
            {
                return (this.ColData.Count != 0);
            }
        }
        
        public DataRow()
        {
            this._colData = new System.Collections.ObjectModel.Collection<ColData>();
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("rowNumber")]
        public string RowNumber { get; set; }
    }
}