using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Pais
{
    [Key]
    public int IdPais { get; set; }
    public string NombrePais { get; set; }
    public ICollection<Region> Regiones {get; set; }
}