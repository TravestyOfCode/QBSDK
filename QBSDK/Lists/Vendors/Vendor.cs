using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;
namespace QBSDK;

public class Vendor : QBListEntity
{
    public Vendor() : base() { }
    internal Vendor(XElement element) : base(element) { }
}

internal class VendorConfiguration : IEntityTypeConfiguration<Vendor>
{
    public void Configure(EntityTypeBuilder<Vendor> builder)
    {
        builder.ToTable(nameof(Vendor));

        builder.HasIndex(p => p.ListID)
            .IsClustered(false)
            .IsUnique(true);
    }
}
