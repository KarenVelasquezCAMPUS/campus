using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class HamburguesaRepository : GenericRepository<Hamburguesa>, IHamburguesaRepository
{
    private readonly ApiContext _context;

    public HamburguesaRepository(ApiContext context) : base(context)
    {
    }
 }