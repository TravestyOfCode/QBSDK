using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("DetailAccountType", Namespace="", AnonymousType=true)]
    [XmlRoot("DetailAccountType", Namespace="")]
    public enum DetailAccountType
    {        
        AP,
        
        AR,
        
        AccumulatedAdjustment,
        
        AccumulatedAmortization,
        
        AccumulatedAmortizationOfOtherAssets,
        
        AccumulatedDepletion,
        
        AccumulatedDepreciation,
        
        AdvertisingOrPromotional,
        
        AllowanceForBadDebts,
        
        Amortization,
        
        Auto,
        
        BadDebts,
        
        BankCharges,
        
        Buildings,
        
        CashOnHand,
        
        CharitableContributions,
        
        Checking,
        
        CommonStock,
        
        CostOfLabor,
        
        CostOfLaborCOS,
        
        CreditCard,
        
        DepletableAssets,
        
        Depreciation,
        
        DevelopmentCosts,
        
        DiscountsOrRefundsGiven,
        
        DividendIncome,
        
        DuesAndSubscriptions,
        
        EmployeeCashAdvances,
        
        Entertainment,
        
        EntertainmentMeals,
        
        EquipmentRental,
        
        EquipmentRentalCOS,
        
        FederalIncomeTaxPayable,
        
        FurnitureAndFixtures,
        
        Goodwill,
        
        Insurance,
        
        InsurancePayable,
        
        IntangibleAssets,
        
        InterestEarned,
        
        InterestPaid,
        
        Inventory,
        
        InvestmentMortgageOrRealEstateLoans,
        
        InvestmentOther,
        
        InvestmentTaxExemptSecurities,
        
        InvestmentUSGovObligations,
        
        Land,
        
        LeaseBuyout,
        
        LeaseholdImprovements,
        
        LegalAndProfessionalFees,
        
        Licenses,
        
        LineOfCredit,
        
        LoanPayable,
        
        LoansToOfficers,
        
        LoansToOthers,
        
        LoansToStockholders,
        
        MachineryAndEquipment,
        
        MoneyMarket,
        
        NonProfitIncome,
        
        NotesPayable,
        
        OfficeOrGeneralAdministrativeExpenses,
        
        OpeningBalanceEquity,
        
        OrganizationalCosts,
        
        OtherCostsOfServiceCOS,
        
        OtherCurrentAssets,
        
        OtherCurrentLiab,
        
        OtherFixedAssets,
        
        OtherInvestmentIncome,
        
        OtherLongTermAssets,
        
        OtherLongTermLiab,
        
        OtherMiscExpense,
        
        OtherMiscIncome,
        
        OtherMiscServiceCost,
        
        OtherPrimaryIncome,
        
        OwnersEquity,
        
        PaidInCapitalOrSurplus,
        
        PartnerContributions,
        
        PartnerDistributions,
        
        PartnersEquity,
        
        PayrollClearing,
        
        PayrollExpenses,
        
        PayrollTaxPayable,
        
        PenaltiesAndSettlements,
        
        PreferredStock,
        
        PrepaidExpenses,
        
        PrepaidExpensesPayable,
        
        PromotionalMeals,
        
        RentOrLeaseOfBuildings,
        
        RentsHeldInTrust,
        
        RentsInTrustLiab,
        
        RepairAndMaintenance,
        
        Retainage,
        
        RetainedEarnings,
        
        SalesOfProductIncome,
        
        SalesTaxPayable,
        
        Savings,
        
        SecurityDeposits,
        
        ServiceOrFeeIncome,
        
        ShareholderNotesPayable,
        
        ShippingFreightAndDelivery,
        
        ShippingFreightAndDeliveryCOS,
        
        StateOrLocalIncomeTaxPayable,
        
        SuppliesAndMaterials,
        
        SuppliesAndMaterialsCOGS,
        
        TaxExemptInterest,
        
        TaxesPaid,
        
        Travel,
        
        TravelMeals,
        
        TreasuryStock,
        
        TrustAccounts,
        
        TrustAccountsLiab,
        
        UndepositedFunds,
        
        Utilities,
        
        Vehicles,
    }
}
