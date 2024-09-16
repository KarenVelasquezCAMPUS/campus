using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class AcudienteConfiguration : IEntityTypeConfiguration<Acudiente>
{
    public void Configure(EntityTypeBuilder<Acudiente> builder)
    {
        builder.ToTable("Acudiente");
        builder.Property(p => p.Code).IsRequired();
        builder.Property(p => p.FullName).IsRequired().HasMaxLength(100);
        builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Address).IsRequired().HasMaxLength(200);
    }
}