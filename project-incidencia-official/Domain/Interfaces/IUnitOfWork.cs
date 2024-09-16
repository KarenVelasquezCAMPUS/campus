namespace Domain.Interfaces;
public interface IUnitOfWork
{
    IAreaRepository Areas { get; }
    IAreaUserRepository AreaUsers { get; }
    IContactCategoryRepository ContactCategories { get; }
    IContactRepository Contacts { get; }
    IContactTypeRepository ContactTypes { get; }
    IDocTypeRepository DocTypes { get; }
    IIncidenceDetailRepository IncidenceDetails { get; }
    IIncidenceLevelRepository IncidenceLevels { get; }
    IIncidenceRepository Incidences { get; }
    IIncidenceTypeRepository IncidenceTypes { get; }
    IPlaceRepository Places { get; }
    IRoleRepository Roles { get; }
    IStateRepository States { get; }
    IUserRepository Users { get; }
    IWorkToolRepository WorkTools { get; }
    Task<int> SaveAsync();
}