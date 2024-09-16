namespace Domain.Entities;
public class ContactType : BaseEntity
{
    public string Description { get; set; }

    //             ICollection   
    public ICollection<Contact> Contacts { get; set; }
}