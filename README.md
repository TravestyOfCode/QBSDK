# QBSDK
A basic .NET wrapper for the QuickBooks Desktop SDK

This project contains two libraries. QBSDK.Provider is an attempt to make a LINQ provider to generate QBXML. QBSDK is a simple wrapper class for generating QBXML requests and processing them. QBSDK currently supports:

## Lists
| Object | QueryRq | AddRq | ModRq | DelRq |
| -------|:-------:|:-----:|:-----:|:-----:|
| Account| Yes     | Yes    | Yes    | Yes    |
|BillingRate |No | No | No | No |
|Class |No | No | No | No |
|Currency |No | No | No | No |
|Customer |Yes | Yes | Yes | Yes |
|CustomerType |No | No | No | No |
|Employee |No | No | No | No |
|Entity |No | No | No | No |
|InventorySite |No | No | No | No |
|ItemDiscount |No | No | No | No |
|ItemFixedAsset |No | No | No | No |
|ItemGroup |No | No | No | No |
|ItemInventory |No | No | No | No |
|ItemInventoryAssembly |No | No | No | No |
|ItemNonInventory |No | No | No | No |
|ItemOther |No | No | No | No |
|ItemPayment |No | No | No | No |
|ItemSalesTax |No | No | No | No |
|ItemService |No | No | No | No |
|ItemSubtotal |No | No | No | No |
|JobType |No | No | No | No |
|Lead |No | No | No | No |
|OtherName |No | No | No | No |
|PaymentMethod |No | No | No | No |
|PayrollItemNonWage |No | No | No | No |
|PayrollItemWage |No | No | No | No |
|PriceLevel |No | No | No | No |
|SalesRep |No | No | No | No |
|SalesTaxCode |No | No | No | No |
|ShipMethod |No | No | No | No |
|StandardTerms |No | No | No | No |
|Terms |No | No | No | No |
|UnitOfMeasureSet |No | No | No | No |
|VehicleQuery |No | No | No | No |
|Vendor |No | No | No | No |
|WorkersCompCode |No | No | No | No 

## Transactions
No Transactions are supported at this time.
