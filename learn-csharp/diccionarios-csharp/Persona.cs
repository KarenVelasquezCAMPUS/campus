namespace diccionarios_csharp;
public class Persona{
    private string ? id;
    private string ? name;
    private string ? emailAddress;
    private DateTime dateRegistered;
    public string ? Id {get => id; set => id = value; }
    public string ? Name {get => name; set => name = value; }
    public string ? EmailAddress {get => emailAddress; set => emailAddress = value; }
    public DateTime DateRegistered {get => dateRegistered; set => dateRegistered = value; }
    public Persona() {
        
    }
    public Persona(String id, string name, string emailAddress, DateTime date){
        this.Id = id;
        this.Name = name;
        this.EmailAddress = emailAddress;
        this.DateRegistered = date;
    }
}