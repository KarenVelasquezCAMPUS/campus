
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class AreaUserConfiguration : IEntityTypeConfiguration<AreaUser>
    {
        public void Configure(EntityTypeBuilder<AreaUser> builder)
        {
            builder.ToTable("areauser");

            builder.HasKey(p => p.Id);

            builder.Property(a => a.Id )
            .IsRequired();

            builder.HasOne(c => c.User)
            .WithMany(c => c.AreaUsers)
            .HasForeignKey(c => c.IdUserFk);

            builder.HasOne(c => c.Area)
            .WithMany(c => c.AreaUsers)
            .HasForeignKey(c => c.IdAreaFk);
        }
    }
}