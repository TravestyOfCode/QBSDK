using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ListDelType", Namespace="", AnonymousType=true)]
    [XmlRoot("ListDelType", Namespace="")]
    public enum ListDelType
    {        
        Account,
        
        BillingRate,
        
        Class,
        
        Currency,
        
        Customer,
        
        CustomerMsg,
        
        CustomerType,
        
        DateDrivenTerms,
        
        Employee,
        
        InventorySite,
        
        ItemDiscount,
        
        ItemFixedAsset,
        
        ItemGroup,
        
        ItemInventory,
        
        ItemInventoryAssembly,
        
        ItemNonInventory,
        
        ItemOtherCharge,
        
        ItemPayment,
        
        ItemSalesTax,
        
        ItemSalesTaxGroup,
        
        ItemService,
        
        ItemSubtotal,
        
        JobType,
        
        OtherName,
        
        PaymentMethod,
        
        PayrollItemNonWage,
        
        PayrollItemWage,
        
        PriceLevel,
        
        SalesRep,
        
        SalesTaxCode,
        
        ShipMethod,
        
        StandardTerms,
        
        ToDo,
        
        UnitOfMeasureSet,
        
        Vehicle,
        
        Vendor,
        
        VendorType,
        
        WorkersCompCode,
    }
}
