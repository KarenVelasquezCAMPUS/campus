namespace Core.Entities;

public partial class Formapago
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Movimientoinventario> Movimientoinventarios { get; set; } = new List<Movimientoinventario>();
}
