using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.ToTable("Medico");
        builder.Property(p => p.NroMatriculaProfesional).IsRequired();
        builder.Property(p => p.FullName).IsRequired().HasMaxLength(120);
        builder.Property(p => p.Consultorio).IsRequired();
        builder.Property(p => p.Especialidad).IsRequired();

        builder.HasOne(p => p.Especialidades).WithMany(e => e.Medicos).HasForeignKey(f => f.IdEspecialidad);
        builder.HasOne(p => p.Consultorios).WithMany(e => e.Medicos).HasForeignKey(f => f.IdConsultorio);
    }

}