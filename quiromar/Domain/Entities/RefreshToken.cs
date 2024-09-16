namespace Domain.Entities;
public class RefreshToken : BaseEntity
{
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public bool IsExpired => DateTime.UtcNow >= Expires;
    public DateTime Created { get; set; }
    public DateOnly? Revoked { get; set; }
    public bool IsActive => Revoked == null && !IsExpired;
}