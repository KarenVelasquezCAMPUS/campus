namespace Domain.Entities;
public class PersonType : BaseEntity
{
    public string Description { get; set; }
    

    //                  ICollection
    public ICollection<Person> Persons { get; set; }
}