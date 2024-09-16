using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuario");
        builder.Property(p => p.Id)
                .IsRequired();
        builder.Property(p => p.Username)
                .IsRequired()
                .HasMaxLength(200);
    
        builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(200);
    }
}
