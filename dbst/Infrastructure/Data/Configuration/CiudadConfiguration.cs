using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configuration;
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ciudad");

            entity.HasIndex(e => e.IddepartamentoFk, "FK_iddepartamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IddepartamentoFk).HasColumnName("iddepartamentoFk");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IddepartamentoFkNavigation).WithMany(p => p.Ciudades)
                .HasForeignKey(d => d.IddepartamentoFk)
                .HasConstraintName("FK_iddepartamento");
        });
    }
}