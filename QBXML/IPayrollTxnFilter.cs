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
    public partial interface IPayrollTxnFilter
    {
        
        string MaxReturned
        {
            get;
            set;
        }
        
        ModifiedDateRangeFilter ModifiedDateRangeFilter
        {
            get;
            set;
        }
        
        TxnDateRangeFilter TxnDateRangeFilter
        {
            get;
            set;
        }
        
        PayrollDateRangeFilter PayrollDateRangeFilter
        {
            get;
            set;
        }
        
        EntityFilter EntityFilter
        {
            get;
            set;
        }
        
        AccountFilter AccountFilter
        {
            get;
            set;
        }
        
        RefNumberFilter RefNumberFilter
        {
            get;
            set;
        }
        
        RefNumberRangeFilter RefNumberRangeFilter
        {
            get;
            set;
        }
    }
}