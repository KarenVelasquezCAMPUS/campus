namespace Domain.Entities;
public class Card : BaseEntity
{
    public string CardType { get; set; }
    public int CardNumber { get; set; }
    public DateOnly ExpeCard { get; set; }
    public int SecurityCode { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }

    //                  ICollection
    public ICollection<Payment> Payments { get; set; }
}