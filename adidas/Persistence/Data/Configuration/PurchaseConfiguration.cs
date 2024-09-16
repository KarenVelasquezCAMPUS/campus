using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("purchase");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(3);

            builder.Property(p => p.PurchaseDate)
            .IsRequired();

            builder.Property(p => p.TotalCost)
            .IsRequired();

            builder.Property(p => p.Quantity)
            .IsRequired();

            //      Foreaneas
            builder.HasOne(e => e.Person)
           .WithMany(e => e.Purchases)
           .HasForeignKey(e => e.PersonId);
        }
    }
}