namespace Dominio.Entities;
public class TipoPersona
{
    public int IdTipoPersona { get; set; }
    public string DescriptionTipoPersona { get; set; }
    public ICollection<Persona> Personas { get; set; }
}