using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class HamburguesaConfiguration : IEntityTypeConfiguration<Hamburguesa>
    {
        public void Configure(EntityTypeBuilder<Hamburguesa> builder)
        {
            builder.ToTable("hamburguesa");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired();

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Precio)
            .IsRequired()
            .HasMaxLength(30);

            builder
            .HasMany(m => m.Ingredientes)
            .WithMany(m => m.Hamburguesas)
            .UsingEntity<HamburguesaIngrediente>(

                j => j
                .HasOne(o => o.Ingrediente)
                .WithMany(o => o.HamburguesaIngredientes)
                .HasForeignKey(fk => fk.IngredienteFk),

                j => j
                .HasOne(em => em.Hamburguesa)
                .WithMany(e => e.HamburguesaIngredientes)
                .HasForeignKey(em => em.HamburguesaFk),

                j =>
                {
                    j.ToTable("hamburguesaIngrediente");
                    j.HasKey(t => new{t.HamburguesaFk, t.IngredienteFk});
                }
            );
        }
    }
}