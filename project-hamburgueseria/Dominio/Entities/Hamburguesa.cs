namespace Dominio.Entities;
public class Hamburguesa : BaseEntity
{
    public string Nombre { get; set; }
    public int Precio { get; set; }

    /*public int ChefFk { get; set; }
    public Chef Chef { get; set; }
    public int CategoriaFk { get; set; }
    public Categoria Categoria { get; set; }*/

    public ICollection<Ingrediente> Ingredientes { get; set; } = new HashSet<Ingrediente>();
    public ICollection<HamburguesaIngrediente> HamburguesaIngredientes { get; set; }
}