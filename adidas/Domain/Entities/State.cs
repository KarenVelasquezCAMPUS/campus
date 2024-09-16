namespace Domain.Entities;
public class State : BaseEntity
{
    public bool Exist { get; set; }
    public string Description { get; set; }

    //                  ICollection
    public ICollection<Inventory> Inventories { get; set; }
}