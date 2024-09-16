using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        builder.ToTable("Cita");
        builder.Property(p => p.Code).IsRequired();
        builder.Property(p => p.Date).IsRequired().HasColumnType("Date");
        builder.Property(p => p.EstadoCita).IsRequired();
        builder.Property(p => p.Medico).IsRequired();
        builder.Property(p => p.DatosUsuario).IsRequired();

        builder.HasOne(p => p.Usuarios).WithMany(e => e.Citas).HasForeignKey(f => f.PhoneNumberUsuario);
        builder.HasOne(p => p.EstadoCitas).WithMany(e => e.Citas).HasForeignKey(f => f.IdEstadoCita);
        builder.HasOne(p => p.Medicos).WithMany(e => e.Citas).HasForeignKey(f => f.FullNameMedico);
    }
}