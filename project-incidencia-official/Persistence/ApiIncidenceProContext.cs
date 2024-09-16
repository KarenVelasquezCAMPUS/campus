using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Persistence;
public class ApiIncidenceProContext : DbContext
{
    public ApiIncidenceProContext(DbContextOptions<ApiIncidenceProContext> options) : base(options)
    {
    }
    public DbSet<Area> Areas { get; set; }
    public DbSet<AreaUser> AreaUsers { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<ContactCategory> ContactCategories { get; set; }
    public DbSet<ContactType> ContactTypes { get; set; }
    public DbSet<DocType> DocTypes { get; set; }
    public DbSet<Incidence> Incidences { get; set; }
    public DbSet<IncidenceDetail> IncidenceDetails { get; set; }
    public DbSet<IncidenceLevel> IncidenceLevels { get; set; }
    public DbSet<IncidenceType> IncidenceTypes { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<WorkTool> WorkTools { get; set; }
}