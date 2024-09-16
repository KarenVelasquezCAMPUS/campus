using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Usuario
{
    [Key]
    public int Id { get; set; }
    public string ? FirstName { get; set; }
    public string ? SecondName { get; set; }
    public string ? LastName { get; set; }
    public string ? SecondLastName { get; set; }
    public string ? PhoneNumber { get; set; }
    public string ? Address { get; set; }
    public string ? Email { get; set; }
    public int TipoDocumento { get; set; }
    public int Genero { get; set; }
    public int Acudiente { get; set; } 
    public ICollection<Cita> ? Citas { get; set ; } 
    public string ? NameTipoDocumento { get; set; }
    public TipoDocumento ? TipoDocumentos { get; set; }
    public string ? NameGenero { get; set; }
    public Genero ? Generos { get; set; }
    public string ? FullNameAcudiente { get; set; }
    public Acudiente ? Acudientes { get; set; }
}