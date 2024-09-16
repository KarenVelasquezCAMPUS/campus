using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class IngredienteRepository : GenericRepository<Ingrediente>, IIngredienteRepository
{
    private readonly ApiContext _context;

    public IngredienteRepository(ApiContext context) : base(context)
    {
    }
 }