using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(3);

            builder.Property(p => p.Name)
            .HasMaxLength(30);

            builder.Property(p => p.Description)
            .HasMaxLength(50);

            builder.Property(p => p.Stock)
            .IsRequired();

            builder.Property(p => p.Price)
            .IsRequired();

            //      Foreaneas
            builder.HasOne(e => e.Payment)
           .WithMany(e => e.Products)
           .HasForeignKey(e => e.PaymentId);

           builder.HasOne(e => e.Inventory)
           .WithMany(e => e.Products)
           .HasForeignKey(e => e.InventoryId);

           builder.HasOne(e => e.Sale)
           .WithMany(e => e.Products)
           .HasForeignKey(e => e.SaleId);

           builder.HasOne(e => e.Purchase)
           .WithMany(e => e.Products)
           .HasForeignKey(e => e.PurchaseId);
        }
    }
}