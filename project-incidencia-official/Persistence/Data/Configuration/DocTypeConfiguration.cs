using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
  public class DocTypeConfiguration : IEntityTypeConfiguration<DocType>
  {
    public void Configure(EntityTypeBuilder<DocType> builder)
    {
      builder.ToTable("doctype");

      builder.HasKey(p => p.Id);

      builder.Property(d => d.Id )
      .IsRequired();
      
      builder.Property(d => d.Name)
      .IsRequired()
      .HasMaxLength(50);

      builder.Property(d => d.Abbreviation)
      .IsRequired()
      .HasMaxLength(10);
    }
  }
}