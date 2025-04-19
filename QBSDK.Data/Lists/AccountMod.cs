using QBSDK.Data.Utilities;
using System.Xml.Linq;

namespace QBSDK.Data;

public class AccountMod
{
    public int Id { get; set; }
    public int? StatusCode { get; set; }
    public string? StatusSeverity { get; set; }
    public string? StatusMessage { get; set; }

    public required string ListID { get; set; }
    public required string EditSequence { get; set; }
    public string? Name { get; set; }
    public bool? IsActive { get; set; }
    public ListRef? ParentRef { get; set; }
    public AccountType? AccountType { get; set; }
    public string? AccountNumber { get; set; }
    public string? BankNumber { get; set; }
    public string? Desc { get; set; }
    public decimal? OpenBalance { get; set; }
    public DateOnly? OpenBalanceDate { get; set; }
    public ListRef? SalesTaxCodeRef { get; set; }
    public int? TaxLineID { get; set; }
    public ListRef? CurrencyRef { get; set; }

    public XElement ToQBXML(QBVersion version, string name = nameof(AccountMod))
    {
        return new XElement("AccountModRq", new XElement(name)
            .Append(ListID)
            .Append(EditSequence)
            .Append(Name)
            .Append(IsActive)
            .Append(ParentRef)
            .Append(AccountType)
            .Append(AccountNumber)
            .Append(BankNumber)
            .Append(Desc)
            .Append(OpenBalance)
            .Append(OpenBalanceDate)
            .AppendIf(() => version.Supports(6, QBEdition.CA | QBEdition.UK), SalesTaxCodeRef)
            .AppendIf(() => version.Supports(7, QBEdition.US | QBEdition.CA), TaxLineID)
            .AppendIf(() => version.Supports(8), CurrencyRef));
    }
}

public static class AccountModExtensions
{
    public static AccountMod AsMod(this Account entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        ArgumentNullException.ThrowIfNull(entity.ListID);
        ArgumentNullException.ThrowIfNull(entity.EditSequence);

        return new AccountMod()
        {
            ListID = entity.ListID,
            EditSequence = entity.EditSequence,
            Name = entity.Name,
            IsActive = entity.IsActive,
            ParentRef = entity.ParentRef.AsListRef(),
            AccountType = entity.AccountType,
            AccountNumber = entity.AccountNumber,
            BankNumber = entity.BankNumber,
            Desc = entity.Desc,
            //SalesTaxCodeRef = entity.SalesTaxCodeRef.AsListRef(),
            TaxLineID = entity.TaxLineInfo?.TaxLineID,
            //CurrencyRef = entity.CurrencyRef.AsListRef()
        };
    }
}
