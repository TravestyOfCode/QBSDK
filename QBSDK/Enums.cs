using System;

namespace QBSDK
{
    [Flags]
    public enum QBCountry { US, CA, UK, Any = US | CA | UK }
    public enum Iterator { Start, Continue, Stop }
    public enum MetaData { NoMetaData, MetaDataOnly, MetaDataAndResponseData }
    public enum ActiveStatus { ActiveOnly, InactiveOnly, All }
    public enum MatchCriterion { StartsWith, Contains, EndsWith }
    public enum ListType { Account, BillingRate, Class, Currency, Customer, CustomerMsg, CustomerType, DateDrivenTerms, Employee, InventorySite, ItemDiscount, ItemFixedAsset, ItemGroup, ItemInventory, ItemInventoryAssembly, ItemNonInventory, ItemOtherCharge, ItemPayment, ItemSalesTax, ItemSalesTaxGroup, ItemService, ItemSubtotal, JobType, OtherName, PaymentMethod, PayrollItemNonWage, PayrollItemWage, PriceLevel, SalesRep, SalesTaxCode, ShipMethod, StandardTerms, ToDo, UnitOfMeasureSet, Vehicle, Vendor, VendorType, WorkersCompCode }
    public enum AccountType { AccountsPayable, AccountsReceivable, Bank, CostOfGoodsSold, CreditCard, Equity, Expense, FixedAsset, Income, LongTermLiability, NonPosting, OtherAsset, OtherCurrentAsset, OtherCurrentLiability, OtherExpense, OtherIncome }
    public enum CashFlowClassification { None, Operating, Investing, Financing, NotApplicable }
    public enum SpecialAccountType { AccountsPayable, AccountsReceivable, CondenseItemAdjustmentExpenses, CostOfGoodsSold, DirectDepositLiabilities, Estimates, ExchangeGainLoss, InventoryAssets, ItemReceiptAccount, OpeningBalanceEquity, PayrollExpenses, PayrollLiabilities, PettyCash, PurchaseOrders, ReconciliationDifferences, RetainedEarnings, SalesOrders, SalesTaxPayable, UncategorizedExpenses, UncategorizedIncome, UndepositedFunds }
    public enum JobStatus { None, Awarded, Closed, InProgress, NotAwarded, Pending }
    public enum PreferredDeliveryMethod { None, Email, Fax }
    public enum Operator { LessThan, LessThanEqual, Equal, GreaterThan, GreaterThanEqual }
    public enum SalesTaxCountry { Canada, Australia, UK, US }

}
