using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CouleurConfiguration  : IEntityTypeConfiguration<Couleur>
    {
        public void Configure(EntityTypeBuilder<Couleur> builder)
        {
            builder.ToTable("Couleur");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(d => d.Descripcion)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}