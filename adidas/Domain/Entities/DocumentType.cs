namespace Domain.Entities;
public class DocumentType : BaseEntity
{
    public string Description { get; set; }

    //                  ICollection
    public ICollection<Person> Persons { get; set; }
}