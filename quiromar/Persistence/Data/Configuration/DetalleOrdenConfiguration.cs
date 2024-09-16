using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("detalleorden");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(d => d.CantidadProducir)
            .IsRequired();

            builder.Property(d => d.CantidadProducida)
            .IsRequired();

            //FK
            builder.HasOne(f => f.Orden)
            .WithMany(k => k.DetalleOrdenes)
            .HasForeignKey(f => f.IdOrdenFk);

            builder.HasOne(f => f.Prenda)
            .WithMany(k => k.DetalleOrdenes)
            .HasForeignKey(f => f.IdPrendaFk);

            builder.HasOne(f => f.Couleur)
            .WithMany(k => k.DetalleOrdenes)
            .HasForeignKey(f => f.IdCouleurFk);

            builder.HasOne(f => f.Estado)
            .WithMany(k => k.DetalleOrdenes)
            .HasForeignKey(f => f.IdEstadoFk);
        }
    }
}