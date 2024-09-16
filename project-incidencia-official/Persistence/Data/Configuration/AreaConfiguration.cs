using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
  public class AreaConfiguration : IEntityTypeConfiguration<Area>
  {
    public void Configure(EntityTypeBuilder<Area> builder)
    {
      builder.ToTable("area");

      builder.HasKey(p => p.Id);

      builder.Property(a => a.Id )
      .IsRequired();

      builder.Property(a => a.Name)
      .IsRequired()
      .HasMaxLength(50);

      builder.Property(a => a.Description)
      .IsRequired()
      .HasMaxLength(100);
    }
  }
}
