using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("TipoPersona");
        builder.Property(m => m.IdTipoPersona)
            .HasColumnName("IdTipoPersona")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.DescripcionTipoPersona)
            .HasColumnName("DescripcionTipoPersona")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(100);
    }
}