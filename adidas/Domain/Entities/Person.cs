namespace Domain.Entities;
public class Person : BaseEntity
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int GenderId { get; set; }
    public Gender Gender { get; set; }
    public int PersonTypeId { get; set; }
    public PersonType PersonType { get; set; }
    public int DocumentTypeId { get; set; }
    public DocumentType DocumentType { get; set; }
    public int DocumentNumber { get; set; }
    public int ContactId { get; set; }
    public Contact Contact { get; set; }
    public int RoleId { get; set; }
    public Role Role { get; set; }

    //            ICollection
    public ICollection<Card> Cards { get; set; }
    public ICollection<Purchase> Purchases { get; set; }
    public ICollection<Sale> Sales { get; set; }
    public ICollection<User> Users { get; set; }
}