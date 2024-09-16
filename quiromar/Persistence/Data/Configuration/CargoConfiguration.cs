using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("cargo");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(d => d.Descripcion)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(d => d.SueldoBase)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}