using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
  public class ContactCategoryConfiguration : IEntityTypeConfiguration<ContactCategory>
  {
    public void Configure(EntityTypeBuilder<ContactCategory> builder)
    {
      builder.ToTable("contactcategory");

      builder.HasKey(p => p.Id);

      builder.Property(c => c.Id )
      .IsRequired();

      builder.Property(c => c.Name)
      .IsRequired()
      .HasMaxLength(50);
    }
  }
}