using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("departamento");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(d => d.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            //FK
            builder.HasOne(f => f.Pais)
            .WithMany(k => k.Departamentos)
            .HasForeignKey(f => f.IdPaisFk);
        }
    }
}