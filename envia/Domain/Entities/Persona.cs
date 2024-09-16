namespace Domain.Entities
{
    public class Persona : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellico { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public int IdTipoDocumentoFk { get; set; }
        public int NumeroDocumento { get; set; }
        public Telefono Telefono { get; set; }
        public int IdTelefonoFk { get; set; }
        public Email Email { get; set; }
        public int IdEmailFk { get; set; }
        public Rol Rol { get; set; }
        public int IdRolFk { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    }
}