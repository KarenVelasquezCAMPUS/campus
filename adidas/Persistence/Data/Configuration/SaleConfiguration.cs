using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("sale");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(3);

            builder.Property(p => p.SaleDate)
            .IsRequired();

            builder.Property(p => p.TotalCost)
            .IsRequired();

            builder.Property(p => p.Quantity)
            .IsRequired();

            //      Foreaneas
            builder.HasOne(e => e.Person)
           .WithMany(e => e.Sales)
           .HasForeignKey(e => e.PersonId);
        }
    }
}