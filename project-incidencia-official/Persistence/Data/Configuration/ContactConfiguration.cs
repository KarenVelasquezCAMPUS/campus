using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
  public class ContactConfiguration : IEntityTypeConfiguration<Contact>
  {
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
      builder.ToTable("contact");

      builder.HasKey(p => p.Id);

      builder.Property(c => c.Id )
      .IsRequired();

      builder.Property(c => c.Description)
      .IsRequired()
      .HasMaxLength(100);

      builder.HasOne(c => c.User)
      .WithMany(c => c.Contacts)
      .HasForeignKey(c => c.IdUserFk);

      builder.HasOne(c => c.ContactType)
      .WithMany(c => c.Contacts)
      .HasForeignKey(c => c.IdContactTypeFk);

      builder.HasOne(c => c.ContactCategory)
      .WithMany(c => c.Contacts)
      .HasForeignKey(c => c.IdContactCategoryFk);
    }
  }
}
