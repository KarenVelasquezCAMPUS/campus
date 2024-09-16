using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Acudiente
{
    [Key]
    public int Code { get; set; }
    public string ? FullName { get; set; }
    public string ? PhoneNumber { get; set; }
    public string ? Address { get; set; }
    public ICollection<Usuario> ? Usuarios { get; set; }
}