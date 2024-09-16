using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration;
public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("Marca");
        builder.Property(m => m.IdMarca)
            .HasColumnName("IdMarca")
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(m => m.DescripcionMarca)
            .HasColumnName("IdDescipcion")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(50);
    }
}
