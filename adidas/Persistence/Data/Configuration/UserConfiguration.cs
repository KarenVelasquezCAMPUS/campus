using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
{
    {
        builder.ToTable("user");
        
        builder.Property(p => p.Id)
        .IsRequired();
                
        builder.Property(p => p.UserName)
        .HasColumnName("username")
        .HasColumnType("varchar")
        .HasMaxLength(30)
        .IsRequired();


        builder.Property(p => p.Password)
       .HasColumnName("password")
       .HasColumnType("varchar")
       .HasMaxLength(50)
       .IsRequired();

        builder.Property(p => p.Email)
        .HasColumnName("email")
        .HasColumnType("varchar")
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.TwoStepSecret)
        .HasColumnName("twostepsecret");

        builder.Property(p => p.DateCreated)
        .IsRequired()
        .HasColumnName("datacreated")
        .HasColumnType("varchar")
        .HasMaxLength(36);

        builder
       .HasMany(p => p.Roles)
       .WithMany(r => r.Users)
       .UsingEntity<UserRole>(

                   j => j
                   .HasOne(pt => pt.Role)
                   .WithMany(t => t.UserRoles)
                   .HasForeignKey(ut => ut.RoleId),


                   j => j
                   .HasOne(et => et.User)
                   .WithMany(et => et.UserRoles)
                   .HasForeignKey(el => el.UserId),

                   j =>
                   {
                       j.ToTable("userrol");
                       j.HasKey(t => new { t.UserId, t.RoleId });
                   });

                builder.HasMany(p => p.RefreshTokens)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            }

        }
    }
}