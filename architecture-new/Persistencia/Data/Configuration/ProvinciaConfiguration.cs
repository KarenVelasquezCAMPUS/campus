using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
{
    public void Configure(EntityTypeBuilder<Provincia> builder)
    {
        builder.ToTable("Provincia");
        builder.Property(m => m.IdProvincia)
            .HasColumnName("IdProvincia")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.NombreProvincia)
            .HasColumnName("NombreProvincia")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(m => m.IdRegion)
            .HasColumnName("IdRegion")
            .IsRequired()
            .HasMaxLength(12);

        builder.HasOne(p => p.Region)
            .WithMany(p => p.Provincias)
            .HasForeignKey(p => p.IdRegion);
    }
}
