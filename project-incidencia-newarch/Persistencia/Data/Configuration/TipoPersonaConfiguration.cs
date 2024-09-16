using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("tipopersona");

            builder.HasKey(e => e.IdTipoPersona);
            builder.Property(e => e.IdTipoPersona);

            builder.Property(p => p.DescriptionTipoPersona)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}