using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("payment");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(3);

            builder.Property(p => p.Description)
            .HasMaxLength(50);

            //      Foreaneas
            builder.HasOne(e => e.Purchase)
           .WithMany(e => e.Payments)
           .HasForeignKey(e => e.PurchaseId);

           builder.HasOne(e => e.Sale)
           .WithMany(e => e.Payments)
           .HasForeignKey(e => e.SaleId);

           builder.HasOne(e => e.Card)
           .WithMany(e => e.Payments)
           .HasForeignKey(e => e.CardId);
        }
    }
}