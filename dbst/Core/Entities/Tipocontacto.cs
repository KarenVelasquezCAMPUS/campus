namespace Core.Entities;

public partial class Tipocontacto
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Contactopersona> Contactopersonas { get; set; } = new List<Contactopersona>();
}
