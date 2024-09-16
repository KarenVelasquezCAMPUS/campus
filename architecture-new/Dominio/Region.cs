using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Region
{
    [Key]
    public int IdRegion { get; set; }
    public string NombreRegion { get; set; }
    public int IdPais { get; set; }
    public Pais Pais { get; set; }
    public ICollection<Provincia> Provincias { get; set; }
}