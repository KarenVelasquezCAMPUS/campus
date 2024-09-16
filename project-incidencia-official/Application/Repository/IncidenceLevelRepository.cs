using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class IncidenceLevelRepository : GenericRepository<IncidenceLevel>, IIncidenceLevelRepository
{
    private readonly ApiIncidenceProContext _context;
    public IncidenceLevelRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<IncidenceLevel>> GetAllAsync()
    {
        return await _context.IncidenceLevels
                            .Include(a => a.IncidenceDetails)
                            .ToListAsync();
    }
}