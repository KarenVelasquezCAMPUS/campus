namespace Domain.Entities;
public class Role : BaseEntity
{
    public string Name { get; set; }

    //                  ICollection
    public ICollection<User> Users { get; set; } = new HashSet<User>();
    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<Person> Persons { get; set; }
}