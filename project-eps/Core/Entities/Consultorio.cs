using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Consultorio
{
    [Key]
    public int Code { get; set; }
    public string ? Name { get; set; }
    public ICollection<Medico> ? Medicos { get; set; }
}