using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("SpecialAccountType", Namespace="", AnonymousType=true)]
    [XmlRoot("SpecialAccountType", Namespace="")]
    public enum SpecialAccountType
    {        
        AccountsPayable,
        
        AccountsReceivable,
        
        CondenseItemAdjustmentExpenses,
        
        CostOfGoodsSold,
        
        DirectDepositLiabilities,
        
        Estimates,
        
        ExchangeGainLoss,
        
        InventoryAssets,
        
        ItemReceiptAccount,
        
        OpeningBalanceEquity,
        
        PayrollExpenses,
        
        PayrollLiabilities,
        
        PettyCash,
        
        PurchaseOrders,
        
        ReconciliationDifferences,
        
        RetainedEarnings,
        
        SalesOrders,
        
        SalesTaxPayable,
        
        UncategorizedExpenses,
        
        UncategorizedIncome,
        
        UndepositedFunds,
    }
}