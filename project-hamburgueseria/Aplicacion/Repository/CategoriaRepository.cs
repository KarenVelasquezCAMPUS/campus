using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
{
    private readonly ApiContext _context;

    public CategoriaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
}