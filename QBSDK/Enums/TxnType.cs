using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("TxnType", Namespace="", AnonymousType=true)]
    [XmlRoot("TxnType", Namespace="")]
    public enum TxnType
    {        
        ARRefundCreditCard,
        
        Bill,
        
        BillPaymentCheck,
        
        BillPaymentCreditCard,
        
        BuildAssembly,
        
        Charge,
        
        Check,
        
        CreditCardCharge,
        
        CreditCardCredit,
        
        CreditMemo,
        
        Deposit,
        
        Estimate,
        
        InventoryAdjustment,
        
        Invoice,
        
        ItemReceipt,
        
        JournalEntry,
        
        LiabilityAdjustment,
        
        Paycheck,
        
        PayrollLiabilityCheck,
        
        PurchaseOrder,
        
        ReceivePayment,
        
        SalesOrder,
        
        SalesReceipt,
        
        SalesTaxPaymentCheck,
        
        Transfer,
        
        VendorCredit,
        
        YTDAdjustment,
    }
}
