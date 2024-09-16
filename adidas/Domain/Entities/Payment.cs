namespace Domain.Entities;
public class Payment : BaseEntity
{
    public string Description { get; set; }
    public int PurchaseId { get; set; }
    public Purchase Purchase { get; set; }
    public int SaleId { get; set; }
    public Sale Sale { get; set; }
    public int CardId { get; set; }
    public Card Card { get; set; }
    

    //                  ICollection
    public ICollection<Product> Products { get; set; }
}