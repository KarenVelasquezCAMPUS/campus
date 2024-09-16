namespace Dominio.Entities;
public class HamburguesaIngrediente : BaseEntity
{
    public string HamburguesaFk { get; set; }
    public Hamburguesa Hamburguesa { get; set; }
    public string IngredienteFk { get; set; }
    public Ingrediente Ingrediente { get; set; }
}