namespace Domain.Entities;
public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }
    public int PaymentId { get; set; }
    public Payment Payment { get; set; }
    public int InventoryId { get; set; }
    public Inventory Inventory { get; set; }
    public int SaleId { get; set; }
    public Sale Sale { get; set; }
    public int PurchaseId { get; set; }
    public Purchase Purchase { get; set; }
}