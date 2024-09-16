using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly ApiIncidenceProContext _context;
    public UserRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.Users
                            .Include(a => a.Incidences)
                            .Include(a => a.Contacts)
                            .Include(a => a.AreaUsers)
                            .ToListAsync();
    }
}