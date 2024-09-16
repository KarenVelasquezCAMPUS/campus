using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(d => d.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(d => d.FechaRegistro)
            .IsRequired();

            //FK
            builder.HasOne(f => f.TipoPersona)
            .WithMany(k => k.Clientes)
            .HasForeignKey(f => f.IdTipoPersonaFk);

            builder.HasOne(f => f.Municipio)
            .WithMany(k => k.Clientes)
            .HasForeignKey(f => f.IdMunicipioFk);
        }
    }
}