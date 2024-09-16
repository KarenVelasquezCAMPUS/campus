using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class PersonaProductoConfiguration : IEntityTypeConfiguration<PersonaProducto>
{
    public void Configure(EntityTypeBuilder<PersonaProducto> builder)
    {
        builder.ToTable("PersonaProducto");
        builder.Property(m => m.IdPersona)
            .HasColumnName("IdPersona")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.IdProducto)
            .HasColumnName("IdProducto")
            .IsRequired()
            .HasMaxLength(12);
            
        builder.HasOne(p => p.Persona)
            .WithMany(p => p.PersonaProductos)
            .HasForeignKey(p => p.IdPersona);

        builder.HasOne(p => p.Producto)
            .WithMany(p => p.PersonaProductos)
            .HasForeignKey(p => p.IdProducto);
    }
}
