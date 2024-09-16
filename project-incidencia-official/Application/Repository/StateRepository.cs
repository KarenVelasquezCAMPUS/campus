using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class StateRepository : GenericRepository<State>, IStateRepository
{
    private readonly ApiIncidenceProContext _context;
    public StateRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<State>> GetAllAsync()
    {
        return await _context.States
                            .Include(a => a.Incidences)
                            .Include(a => a.IncidenceDetails)
                            .ToListAsync();
    }
}