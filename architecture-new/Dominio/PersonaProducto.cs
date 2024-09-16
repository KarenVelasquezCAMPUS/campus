using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class PersonaProducto
{
    [Key]
    public int IdPersona { get; set; }
    public Persona Persona { get; set; }
    public int IdProducto { get; set; }
    public Producto Producto { get; set; }
}