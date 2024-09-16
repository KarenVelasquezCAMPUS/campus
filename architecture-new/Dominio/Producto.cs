using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Producto 
{
    [Key]
    public int IdProducto { get; set; }
    public int ReferenciaProducto { get; set; }
    public string DescripcionProducto  { get; set; }
    public string PrecioProducto { get; set; }
    public string DescuentoProducto { get; set; }
    public int IdMarca { get; set; }
    public Marca Marca { get; set; }
    public ICollection<PersonaProducto> PersonaProductos { get; set; }
}