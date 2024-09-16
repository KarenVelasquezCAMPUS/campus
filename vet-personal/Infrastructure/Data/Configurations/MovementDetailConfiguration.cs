using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class MovementDetailConfiguration : IEntityTypeConfiguration<MovementDetail>
    {
        public void Configure(EntityTypeBuilder<MovementDetail> builder)
        {
            builder.ToTable("movementdetail");

            builder.HasKey(p => p.Id);

            // Properties
            builder.Property(p => p.Id)
            .IsRequired()
            .HasColumnName("id");

            builder.Property(p => p.Amount)
            .IsRequired()
            .HasColumnName("amount");

            builder.Property(p => p.Price)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("price");

            //Relations
            builder.HasOne(o => o.Medicine)
            .WithMany(m => m.MovementDetails)
            .HasForeignKey(o => o.MedicineId);

            builder.HasOne(o => o.MovementMedicine)
            .WithMany(m => m.MovementDetails)
            .HasForeignKey(o => o.MovementMedicineId);
        }
    }
}