using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Medico
{
    [Key]
    public int NroMatriculaProfesional { get; set; }
    public string ? FullName { get; set; }
    public int Consultorio { get; set; }
    public int Especialidad { get; set; }
    public ICollection<Cita> ? Citas { get; set; }
    public string ? IdEspecialidad { get; set; }
    public Especialidad ? Especialidades { get; set; }
    public string ? IdConsultorio { get; set; }
    public Consultorio ? Consultorios { get; set; }
}
