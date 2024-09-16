using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Persistence.Data.Configuration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("card");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasColumnName("card_id")
            .HasMaxLength(3);

            builder.Property(p => p.CardType)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.CardNumber)
            .IsRequired();

            builder.Property(p => p.ExpeCard)
            .IsRequired();

            builder.Property(p => p.SecurityCode)
            .IsRequired();

            builder.Property(p => p.PersonId)
            .IsRequired();


            //      Foreaneas
            builder.HasOne(e => e.Person)
           .WithMany(e => e.Cards)
           .HasForeignKey(e => e.PersonId);
        }
    }
}