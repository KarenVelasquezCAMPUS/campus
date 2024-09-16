namespace Domain.Entities;
public class Gender : BaseEntity
{
    public string Description { get; set; }
    

    //                  ICollection
    public ICollection<Person> Persons { get; set; }
}