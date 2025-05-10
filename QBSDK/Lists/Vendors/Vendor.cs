using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QBSDK;

public class Vendor : QBListEntity
{

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
