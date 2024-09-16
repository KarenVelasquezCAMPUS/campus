namespace Dominio.Entities;
public class Pais
{
    public int IdPais { get; set; }
    public string NombrePais { get; set; }
    public ICollection<Departamento> Departamentos { get; set; }
}