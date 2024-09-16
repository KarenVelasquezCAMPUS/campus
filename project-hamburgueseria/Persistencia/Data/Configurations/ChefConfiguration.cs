using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class ChefConfiguration : IEntityTypeConfiguration<Chef>
    {
        public void Configure(EntityTypeBuilder<Chef> builder)
        {
            builder.ToTable("chef");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired();
             
            builder.Property(p => p.Nombre)
           .IsRequired()
           .HasMaxLength(50);

           builder.Property(p => p.Especialidad)
          .IsRequired()
          .HasMaxLength(80);
        }
    }
}