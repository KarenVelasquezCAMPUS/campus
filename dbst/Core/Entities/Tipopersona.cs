namespace Core.Entities;

public partial class Tipopersona
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
