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
    [System.Xml.Serialization.XmlTypeAttribute("JobReportQueryRqType", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class JobReportQueryRqType : global::QBXML.IJobReportQuery
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("JobReportType")]
        public global::QBXML.JobReportType JobReportType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DisplayReport")]
        public string DisplayReport { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportPeriod")]
        public global::QBXML.ReportPeriod ReportPeriod { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportDateMacro")]
        public global::QBXML.ReportDateMacro ReportDateMacro { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportDateMacroSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportAccountFilter")]
        public global::QBXML.ReportAccountFilter ReportAccountFilter { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportEntityFilter")]
        public global::QBXML.ReportEntityFilter ReportEntityFilter { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportItemFilter")]
        public global::QBXML.ReportItemFilter ReportItemFilter { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportClassFilter")]
        public global::QBXML.ReportClassFilter ReportClassFilter { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<global::QBXML.TxnTypeFilter> _reportTxnTypeFilter;
        
        [System.Xml.Serialization.XmlArrayAttribute("ReportTxnTypeFilter")]
        [System.Xml.Serialization.XmlArrayItemAttribute("TxnTypeFilter")]
        public System.Collections.ObjectModel.Collection<global::QBXML.TxnTypeFilter> ReportTxnTypeFilter
        {
            get
            {
                return _reportTxnTypeFilter;
            }
            private set
            {
                _reportTxnTypeFilter = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportTxnTypeFilterSpecified
        {
            get
            {
                return (this.ReportTxnTypeFilter.Count != 0);
            }
        }
        
        public JobReportQueryRqType()
        {
            this._reportTxnTypeFilter = new System.Collections.ObjectModel.Collection<global::QBXML.TxnTypeFilter>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportModifiedDateRangeFilter")]
        public global::QBXML.ReportModifiedDateRangeFilter ReportModifiedDateRangeFilter { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportModifiedDateRangeMacro")]
        public global::QBXML.ReportModifiedDateRangeMacro ReportModifiedDateRangeMacro { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportModifiedDateRangeMacroSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportDetailLevelFilter")]
        public global::QBXML.ReportDetailLevelFilter ReportDetailLevelFilter { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportDetailLevelFilterSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ReportPostingStatusFilter")]
        public global::QBXML.ReportPostingStatusFilter ReportPostingStatusFilter { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportPostingStatusFilterSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SummarizeColumnsBy")]
        public global::QBXML.SummarizeColumnsBy SummarizeColumnsBy { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SummarizeColumnsBySpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("IncludeSubcolumns")]
        public string IncludeSubcolumns { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("requestID")]
        public string RequestID { get; set; }
    }
}