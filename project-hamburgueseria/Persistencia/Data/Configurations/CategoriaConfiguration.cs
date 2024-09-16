using System.Collections.Immutable;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired();

            builder.Property(p => p.Nombre)
           .IsRequired()
           .HasMaxLength(50);

           builder.Property(p => p.Descripcion)
          .IsRequired()
          .HasMaxLength(100);
          
        }
    }
}