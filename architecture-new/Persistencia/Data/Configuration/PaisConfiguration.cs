using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Pais");
        builder.Property(m => m.IdPais)
            .HasColumnName("IdPais")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.NombrePais)
            .HasColumnName("NombrePais")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(50);
    }
}