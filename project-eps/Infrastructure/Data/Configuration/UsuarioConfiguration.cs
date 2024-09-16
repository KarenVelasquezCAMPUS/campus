using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configutation;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.Property(p => p.Id).IsRequired();
        builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
        builder.Property(p => p.SecondName).IsRequired().HasMaxLength(45);
        builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
        builder.Property(p => p.SecondLastName).IsRequired().HasMaxLength(50);
        builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Address).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Email).IsRequired().HasMaxLength(100);
        builder.Property(p => p.TipoDocumento).IsRequired();
        builder.Property(p => p.Genero).IsRequired();
        builder.Property(p => p.Acudiente).IsRequired();

        builder.HasOne(p => p.TipoDocumentos).WithMany(e => e.Usuarios).HasForeignKey(f => f.NameTipoDocumento);
        builder.HasOne(p => p.Generos).WithMany(e => e.Usuarios).HasForeignKey(f => f.NameGenero);
        builder.HasOne(p => p.Acudientes).WithMany(e => e.Usuarios).HasForeignKey(f => f.FullNameAcudiente);
    }
}