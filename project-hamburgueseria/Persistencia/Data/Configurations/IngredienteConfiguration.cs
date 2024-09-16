using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class IngredienteConfiguration : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("Ingrediente");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired();
             
            builder.Property(p => p.Nombre)
           .IsRequired()
           .HasMaxLength(50);

           builder.Property(p => p.Descripcion)
          .IsRequired()
          .HasMaxLength(100);

          builder.Property(p => p.Precio)
          .IsRequired()
          .HasMaxLength(30);

          builder.Property(p => p.Stock)
          .IsRequired()
          .HasMaxLength(100);
        }
    }
}

/* using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class IngredienteConfiguration : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("ingrediente");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdIngrediente");

            builder.Property(r => r.Nombre)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("NombreIngrediente");

            builder.Property(r => r.Descripcion)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("DescripcionIngrediente");

            builder.Property(r => r.Precio)
            .IsRequired()
            .HasColumnName("PrecioIngrediente");

            builder.Property(r => r.Stock)
            .IsRequired()
            .HasColumnName("StockIngrediente");
        }
    }
} */