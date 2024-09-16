namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    ICategoriaRepository Categorias { get; }
    IChefRepository Chefs { get; }
    IHamburguesaRepository Hamburguesas { get; }
    //IHamburguesaIngredienteRepository HamburguesaIngredientes { get; }
    IIngredienteRepository Ingredientes { get; }

    Task<int> SaveAsync();
}