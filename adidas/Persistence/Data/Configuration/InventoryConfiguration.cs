using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("inventory");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(3);

            //      Foreaneas
            builder.HasOne(e => e.Purchase)
           .WithMany(e => e.Inventories)
           .HasForeignKey(e => e.PurchaseId);

           builder.HasOne(e => e.Sale)
           .WithMany(e => e.Inventories)
           .HasForeignKey(e => e.SaleId);

           builder.HasOne(e => e.State)
           .WithMany(e => e.Inventories)
           .HasForeignKey(e => e.StateId);
        }
    }
}