namespace Domain.Entities;
public class Inventory : BaseEntity
{
    public int PurchaseId { get; set; }
    public Purchase Purchase { get; set; }
    public int SaleId { get; set; }
    public Sale Sale { get; set; }
    public int StateId { get; set; }
    public State State { get; set; }

    //                  ICollection
    public ICollection<Product> Products { get; set; }
}