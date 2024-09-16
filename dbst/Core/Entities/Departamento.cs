namespace Core.Entities;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public int? IdpaisFk { get; set; }

    public virtual ICollection<Ciudad> Ciudades { get; set; } = new List<Ciudad>();

    public virtual Pais IdpaisFkNavigation { get; set; }
}
