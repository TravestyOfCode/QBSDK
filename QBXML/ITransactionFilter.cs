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
    public partial interface ITransactionFilter
    {
        
        string MaxReturned
        {
            get;
            set;
        }
        
        System.Collections.ObjectModel.Collection<string> RefNumber
        {
            get;
        }
        
        System.Collections.ObjectModel.Collection<string> RefNumberCaseSensitive
        {
            get;
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
        
        TransactionModifiedDateRangeFilter TransactionModifiedDateRangeFilter
        {
            get;
            set;
        }
        
        TransactionDateRangeFilter TransactionDateRangeFilter
        {
            get;
            set;
        }
        
        TransactionEntityFilter TransactionEntityFilter
        {
            get;
            set;
        }
        
        TransactionAccountFilter TransactionAccountFilter
        {
            get;
            set;
        }
        
        TransactionItemFilter TransactionItemFilter
        {
            get;
            set;
        }
        
        TransactionClassFilter TransactionClassFilter
        {
            get;
            set;
        }
        
        System.Collections.ObjectModel.Collection<TxnTypeFilter> TransactionTypeFilter
        {
            get;
        }
        
        TransactionDetailLevelFilter TransactionDetailLevelFilter
        {
            get;
            set;
        }
        
        TransactionPostingStatusFilter TransactionPostingStatusFilter
        {
            get;
            set;
        }
        
        TransactionPaidStatusFilter TransactionPaidStatusFilter
        {
            get;
            set;
        }
        
        CurrencyFilter CurrencyFilter
        {
            get;
            set;
        }
    }
}