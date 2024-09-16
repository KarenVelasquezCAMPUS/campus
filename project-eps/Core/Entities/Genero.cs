using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Genero
{
    [Key]
    public int Id { get; set; }
    public string ? Name { get; set; }
    public string ? Abbreviation { get; set; }
    public ICollection<Usuario> ? Usuarios { get; set; }
}