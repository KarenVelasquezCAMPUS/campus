using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Cita
{
    [Key]
    public int Code { get; set; }
    public DateTime Date { get; set; }
    public int EstadoCita { get; set; }
    public int Medico { get; set; }
    public int DatosUsuario { get; set; }
    public string ? PhoneNumberUsuario { get; set; }
    public Usuario ? Usuarios { get; set; }
    public string ? IdEstadoCita { get; set; }
    public EstadoCita ? EstadoCitas { get; set; }
    public string ? FullNameMedico { get; set; }
    public Medico ? Medicos { get; set; }
}