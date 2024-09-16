using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApiIncidenceProContext context;

        private AreaRepository _areas;
        private AreaUserRepository _areaUsers;
        private ContactCategoryRepository _contactCategories;
        private ContactRepository _contacts;
        private ContactTypeRepository _contactTypes;
        private DocTypeRepository _docTypes;
        private IncidenceDetailRepository _incidenceDetails;
        private IncidenceLevelRepository _incidenceLevels;
        private IncidenceRepository _incidences;
        private IncidenceTypeRepository _incidenceTypes;
        private PlaceRepository _places;
        private RoleRepository _roles;
        private StateRepository _states;
        private UserRepository _users;
        private WorkToolRepository _workTools;

        public UnitOfWork(ApiIncidenceProContext _context)
        {
            context = _context;
        }

        public IAreaRepository Areas
        {
            get
            {
                if(_areas == null)
                {
                    _areas = new AreaRepository(context);
                }
                return _areas;
            }
        }
        public IAreaUserRepository AreaUsers 
        {
            get
            {
                if(_areaUsers == null)
                {
                    _areaUsers = new AreaUserRepository(context);
                }
                return _areaUsers;
            }
        }
        public IContactCategoryRepository ContactCategories 
        {
            get
            {
                if(_contactCategories == null)
                {
                    _contactCategories = new ContactCategoryRepository(context);
                }
                return _contactCategories;
            }
        }
        public IContactRepository Contacts
        {
            get
            {
                if(_contacts == null)
                {
                    _contacts = new ContactRepository(context);
                }
                return _contacts;
            }
        }
        public IContactTypeRepository ContactTypes
        {
            get
            {
                if(_contactTypes == null)
                {
                    _contactTypes = new ContactTypeRepository(context);
                }
                return _contactTypes;
            }
        }
        public IDocTypeRepository DocTypes
        {
            get
            {
                if(_docTypes == null)
                {
                    _docTypes = new DocTypeRepository(context);
                }
                return _docTypes;
            }
        }
        public IIncidenceDetailRepository IncidenceDetails
        {
            get
            {
                if(_incidenceDetails == null)
                {
                    _incidenceDetails = new IncidenceDetailRepository(context);
                }
                return _incidenceDetails;
            }
        }
        public IIncidenceLevelRepository IncidenceLevels
        {
            get
            {
                if(_incidenceLevels == null)
                {
                    _incidenceLevels = new IncidenceLevelRepository(context);
                }
                return _incidenceLevels;
            }
        }
        public IIncidenceRepository Incidences
        {
            get
            {
                if(_incidences == null)
                {
                    _incidences = new IncidenceRepository(context);
                }
                return _incidences;
            }
        }
        public IIncidenceTypeRepository IncidenceTypes
        {
            get
            {
                if(_incidenceTypes == null)
                {
                    _incidenceTypes = new IncidenceTypeRepository(context);
                }
                return _incidenceTypes;
            }
        }
        public IPlaceRepository Places
        {
            get
            {
                if(_places == null)
                {
                    _places = new PlaceRepository(context);
                }
                return _places;
            }
        }
        public IRoleRepository Roles
        {
            get
            {
                if(_roles == null)
                {
                    _roles = new RoleRepository(context);
                }
                return _roles;
            }
        }
        public IStateRepository States
        {
            get
            {
                if(_states == null)
                {
                    _states = new StateRepository(context);
                }
                return _states;
            }
        }
        public IUserRepository Users
        {
            get
            {
                if(_users == null)
                {
                    _users = new UserRepository(context);
                }
                return _users;
            }
        }
        public IWorkToolRepository WorkTools
        {
            get
            {
                if(_workTools == null)
                {
                    _workTools = new WorkToolRepository(context);
                }
                return _workTools;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}