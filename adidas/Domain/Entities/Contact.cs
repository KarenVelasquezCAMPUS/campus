namespace Domain.Entities;
public class Contact : BaseEntity
{
    public int ContactTypeId { get; set; }
    public ContactType ContactType { get; set; }
    public string Description { get; set; }
    public string InfoContact { get; set; }

    //                  ICollection
    public ICollection<Person> Persons { get; set; }
}