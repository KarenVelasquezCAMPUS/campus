using diccionarios_csharp;
internal class Program
{
    private static void Main(string[] args)
    {
        Persona person = new Persona();
        DiccDemo dicc = new DiccDemo(); 
        Console.Clear();
        Console.WriteLine("Ingrese Nro Id: ");
        person.Id = Console.ReadLine();
        Console.WriteLine("Ingrese Nombre: ");
        person.Name = Console.ReadLine();
        Console.WriteLine("Ingrese Email: ");
        person.EmailAddress = Console.ReadLine();
        person.DateRegistered = DateTime.UtcNow;

        Console.Clear();
        dicc.AddItem(person.Id ?? "0", person);
        Console.WriteLine("---- Impresion llaves ----");
        dicc.ViewData(0);
        Console.WriteLine("---- Impresion valores ----");
        dicc.ViewData(1);
        Console.WriteLine("---- Impresion de llaves y valores ----");
        dicc.ViewData(2);
    }
}