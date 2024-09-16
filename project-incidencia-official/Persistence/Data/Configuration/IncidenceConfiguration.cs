using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
  public class IncidenceConfiguration : IEntityTypeConfiguration<Incidence>
  {
    public void Configure(EntityTypeBuilder<Incidence> builder)
    {
      builder.ToTable("incidence");

      builder.HasKey(p => p.Id);

      builder.Property(i => i.Id )
      .IsRequired();

      builder.Property(i => i.Description)
      .IsRequired()
      .HasMaxLength(100);

      builder.Property(i => i.Date)
      .IsRequired();
      
      builder.HasOne(i => i.State)
      .WithMany(i => i.Incidences)
      .HasForeignKey(i => i.IdStateFk);

      builder.HasOne(i => i.User)
      .WithMany(i => i.Incidences)
      .HasForeignKey(i => i.IdUserFk);

      builder.HasOne(i => i.Area)
      .WithMany(i => i.Incidences)
      .HasForeignKey(i => i.IdAreaFk);

      builder.HasOne(i => i.Place)
      .WithMany(i => i.Incidences)
      .HasForeignKey(i => i.IdPlaceFk);
    }
  }
}
