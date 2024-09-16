namespace Domain.Entities;
public class User : BaseEntity
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string TwoStepSecret { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public DateTime DateCreated { get; set; } =  DateTime.Now;
    public ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<UserRole> UserRoles { get; set; }
}