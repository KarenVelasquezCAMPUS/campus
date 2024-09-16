using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Producto");
        builder.Property(m => m.IdProducto)
            .HasColumnName("IdProducto")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.ReferenciaProducto)
            .HasColumnName("ReferenciaProducto")
            .IsRequired()
            .HasMaxLength(35);

        builder.Property(m => m.DescripcionProducto)
            .HasColumnName("DescripcionProducto")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.PrecioProducto)
            .HasColumnName("PrecioProducto")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(m => m.DescuentoProducto)
            .HasColumnName("DescuentoProducto")
            .IsRequired()
            .HasMaxLength(35);

        builder.Property(m => m.IdMarca)
            .HasColumnName("IdMarca")
            .IsRequired()
            .HasMaxLength(12);

        builder.HasOne(p => p.Marca)
            .WithMany(p => p.Productos)
            .HasForeignKey(p => p.IdMarca);
    }
}