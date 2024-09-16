using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Region");
        builder.Property(m => m.IdRegion)
            .HasColumnName("IdRegion")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.NombreRegion)
            .HasColumnName("NombreRegion")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(m => m.IdPais)
            .HasColumnName("IdPais")
            .IsRequired()
            .HasMaxLength(12);

        builder.HasOne(p => p.Pais)
            .WithMany(p => p.Regiones)
            .HasForeignKey(p => p.IdPais);
    }
}