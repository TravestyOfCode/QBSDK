namespace QBSDK.Data;

public class Account : ListRefBase
{
    public int Id { get; set; }

    //public string? ListID { get; set; }
    public DateTime? TimeCreated { get; set; }
    public DateTime? TimeModified { get; set; }
    public string? EditSequence { get; set; }
    public string? Name { get; set; }
    //public string? FullName { get; set; }
    public bool? IsActive { get; set; }
    public int? ParentRefId { get; set; }
    public Account? ParentRef { get; set; }
    public int? Sublevel { get; }
    public AccountType? AccountType { get; set; }
    public SpecialAccountType? SpecialAccountType { get; set; }
    public bool? IsTaxAccount { get; set; }
    public string? AccountNumber { get; set; }
    public string? BankNumber { get; set; }
    public string? Desc { get; set; }
    public decimal? Balance { get; set; }
    public decimal? TotalBalance { get; set; }
    //public int? SalesTaxCodeRefId { get; set; }
    //public SalesTaxCode? SalesTaxCodeRef { get; set; }
    public TaxLine? TaxLineInfo { get; set; }
    public CashFlowClassification? CashFlowClassification { get; set; }
    //public int? CurrencyRefId { get; set; }
    //public Currency? CurrencyRef { get; set; }
    //public List<DataExt>? DataExtList { get; set; }
}
