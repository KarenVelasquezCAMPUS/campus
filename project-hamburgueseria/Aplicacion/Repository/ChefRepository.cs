using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class ChefRepository : GenericRepository<Chef>, IChefRepository
{
    private readonly ApiContext _context;

    public ChefRepository(ApiContext context) : base(context)
    {
    }
}