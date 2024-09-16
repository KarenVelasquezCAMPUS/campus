using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Persona");
        builder.Property(m => m.IdPersona)
            .HasColumnName("IdPersona")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.NombrePersona)
            .HasColumnName("NombrePersona")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(m => m.ApellidoPersona)
            .HasColumnName("ApellidoPersona")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(m => m.EdadPersona)
            .HasColumnName("EdadPersona")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.IdProvincia)
            .HasColumnName("IdProvincia")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.IdTipoPersona)
            .HasColumnName("IdTipoPersona")
            .IsRequired()
            .HasMaxLength(12);
        
        builder.HasOne(p => p.Provincia)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdProvincia);

        builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPersona);
    }
}