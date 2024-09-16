using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class EstadoCita
{
    [Key]
    public int Id { get; set; }
    public string ? Name { get; set; }
    public ICollection<Cita> ? Citas { get; set; }
}