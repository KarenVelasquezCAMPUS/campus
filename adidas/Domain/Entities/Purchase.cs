namespace Domain.Entities;
public class Purchase : BaseEntity
{
    public DateOnly PurchaseDate { get; set; }
    public double TotalCost { get; set; }
    public int Quantity { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    
    //                  ICollection
    public ICollection<Inventory> Inventories { get; set; }
    public ICollection<Payment> Payments { get; set; }
    public ICollection<Product> Products { get; set; }
}