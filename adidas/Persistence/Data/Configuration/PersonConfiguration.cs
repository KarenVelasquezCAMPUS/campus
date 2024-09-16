using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("person");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(3);

            builder.Property(p => p.Name)
            .HasMaxLength(30);

            builder.Property(p => p.LastName)
            .HasMaxLength(30);

            builder.Property(p => p.DocumentNumber)
            .IsRequired();

            //      Foreaneas
            builder.HasOne(e => e.Gender)
           .WithMany(e => e.Persons)
           .HasForeignKey(e => e.GenderId);

           builder.HasOne(e => e.PersonType)
           .WithMany(e => e.Persons)
           .HasForeignKey(e => e.PersonTypeId);

           builder.HasOne(e => e.DocumentType)
           .WithMany(e => e.Persons)
           .HasForeignKey(e => e.DocumentTypeId);

           builder.HasOne(e => e.Contact)
           .WithMany(e => e.Persons)
           .HasForeignKey(e => e.ContactId);

           builder.HasOne(e => e.Role)
           .WithMany(e => e.Persons)
           .HasForeignKey(e => e.RoleId);
        }
    }
}