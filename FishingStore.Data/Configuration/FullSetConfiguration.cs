using FishingStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FishingStore.Data.Configuration
{
    public class FullSetConfiguration : IEntityTypeConfiguration<FullSet>
    {
        public void Configure(EntityTypeBuilder<FullSet> builder)
        {
            builder
                .Property(r => r.Price)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");
        }
    }
}
