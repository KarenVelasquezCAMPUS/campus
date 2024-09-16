using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class PlaceRepository : GenericRepository<Place>, IPlaceRepository
{
    private readonly ApiIncidenceProContext _context;
    public PlaceRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Place>> GetAllAsync()
    {
        return await _context.Places
                            .Include(a => a.Incidences)
                            .ToListAsync();
    }
}