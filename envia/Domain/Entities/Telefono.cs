namespace Domain.Entities
{
    public class Telefono : BaseEntity
    {
        public string Empresarial { get; set; }
        public string Personal { get; set; }
        public string Fijo { get; set; }
        public int NumeroTelefono { get; set; }
    }
}