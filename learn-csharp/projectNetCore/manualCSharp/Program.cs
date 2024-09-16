using System.Numerics;
internal partial class Program
{
    private static void Main(string[] args)
    {
    
     // VARIABLES Y CONSTANTES 
        string nombre = string.Empty; //string
        int edad = 0; // number
        double sueldo = 0.0; // float
        bool estado = false; // boolean
        const double iva = 16.8;

        bool check = true; //El valor predeterminado del tipo bool es false.
        Console.WriteLine(check ? "Activo" : "Inactivo");
        Console.WriteLine(false ? "Activo" : "Inactivo"); 

        var a = 12.3;
        double b = 12.3;
        Console.WriteLine($"El valor de a es = {a}");
        Console.WriteLine($"El valor de a es = {b}"); 

        double b = 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($"{d}");
        float f = 3_000.5m;
        myMoney = 400.75M;
        Console.WriteLine($"{myMoney}");
    }
}
internal class Program : NewBaseType
{
}