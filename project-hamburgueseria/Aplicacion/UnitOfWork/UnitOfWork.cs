using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;
    CategoriaRepository _categoria;
    ChefRepository _chef;
    //HamburguesaIngredienteRepository _hamburguesaIngrediente;
    HamburguesaRepository _hamburguesa;
    IngredienteRepository _ingrediente;

    public UnitOfWork (ApiContext context)
    {
        _context = context;
    }

    public ICategoriaRepository Categorias 
    {
        get
        {
            if(_categoria is not null)
            {
                return (ICategoriaRepository)_categoria;
            }
            return (ICategoriaRepository)(_categoria = new CategoriaRepository(_context));
        }
    }

    public IChefRepository Chefs
    {
        get
        {
            if(_chef is not null)
            {
                return (IChefRepository)_chef;
            }
            return (IChefRepository)(_chef = new ChefRepository(_context));
            }
    }

    /* public IHamburguesaIngredienteRepository HamburguesaIngredientes
    {
        get{
            if(_hamburguesaIngredientes == null)
            {
                _hamburguesaIngredientes = new HamburguesaIngredienteRepository(context);
            }
            return _hamburguesaIngredientes;
            }
    } */

    public IHamburguesaRepository Hamburguesas
    {
        get
        {
            if (_hamburguesa is not null)
            {
                return (IHamburguesaRepository)_hamburguesa;
            }
            return (IHamburguesaRepository)(_hamburguesa = new HamburguesaRepository(_context));
        }
    }

    public IIngredienteRepository Ingredientes
    {
        get
        {
            if (_ingrediente is not null)
            {
                return (IIngredienteRepository)_ingrediente;
            }
            return (IIngredienteRepository)(_ingrediente = new IngredienteRepository(_context));
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}