using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Especialidad
{
    [Key]
    public int Id { get; set; }
    public string ? Name { get; set; }
    public ICollection<Medico> ? Medicos { get; set; }
}
