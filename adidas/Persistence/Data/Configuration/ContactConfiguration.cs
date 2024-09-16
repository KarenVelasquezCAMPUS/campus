using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("contact");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(3);

            builder.Property(p => p.Description)
            .HasMaxLength(50);

            builder.Property(p => p.InfoContact)
            .HasMaxLength(30);

            //      Foreaneas
            builder.HasOne(e => e.ContactType)
           .WithMany(e => e.Contacts)
           .HasForeignKey(e => e.ContactTypeId);
        }
    }
}