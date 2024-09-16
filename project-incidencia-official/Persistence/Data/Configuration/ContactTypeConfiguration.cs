using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
  public class ContactTypeConfiguration : IEntityTypeConfiguration<ContactType>
  {
    public void Configure(EntityTypeBuilder<ContactType> builder)
    {
      builder.ToTable("contacttype");

      builder.HasKey(p => p.Id);

      builder.Property(c => c.Id )
      .IsRequired();
      
      builder.Property(c => c.Name)
      .IsRequired()
      .HasMaxLength(50);

      builder.Property(c => c.Description)
      .IsRequired()
      .HasMaxLength(100);
    }
  }
}
