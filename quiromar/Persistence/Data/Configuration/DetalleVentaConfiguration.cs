using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleventa");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(d => d.Cantidad)
            .IsRequired();

            builder.Property(d => d.ValorUnit)
            .IsRequired();

            //FK
            builder.HasOne(f => f.Venta)
            .WithMany(k => k.DetalleVentas)
            .HasForeignKey(f => f.IdVentaFk);

            builder.HasOne(f => f.Prenda)
            .WithMany(k => k.DetalleVentas)
            .HasForeignKey(f => f.IdPrendaFk);

            builder.HasOne(f => f.Talla)
            .WithMany(k => k.DetalleVentas)
            .HasForeignKey(f => f.IdTallaFk);
        }
    }
}