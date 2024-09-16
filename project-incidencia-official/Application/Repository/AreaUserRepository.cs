using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class AreaUserRepository : GenericRepository<AreaUser>, IAreaUserRepository
{
    private readonly ApiIncidenceProContext _context;
    public AreaUserRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<AreaUser>> GetAllAsync()
    {
        return await _context.AreaUsers
                            .ToListAsync();
    }
}