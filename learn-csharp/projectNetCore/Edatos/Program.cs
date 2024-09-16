using System.Collections; // importar algo que no me acuerdo
internal class Program
{
    private static void Main(string[] args)
    {
        /* 
        // METODOS DE ARREGLOS
        int [] edades = {12, 23, 5, 34, 21};
        string numeros = String.Empty;
        Array.Sort(edades); //ordenar de menor a mayor
        foreach (int edad in edades) { // recorrer todos los elemtos de un array
            numeros += edad.ToString()+",";
        }
        Console.WriteLine(numeros.Remove(numeros.Length-1)); */

        /* // LISTAS
        ArrayList myAL = new ArrayList();
        myAL.Add("The"); 
        myAL.Add("quick");
        myAL.Add("brown");
        myAL.Add("fox");
        foreach(Object n in myAL) {
            Console.WriteLine(n.ToString()); // el ToString() es opcional no hace un culo :p
        } 
        ArrayList Carnivoros = new ArrayList();
        ArrayList Acuaticos = new ArrayList();
        ArrayList Animales = new ArrayList();
        Carnivoros.Add("Tigre");
        Carnivoros.Add("Leon");
        Carnivoros.Add("Pantera");
        Carnivoros.Add("Leopardo");
        Acuaticos.Add("Tiburon"); 
        Acuaticos.Add("Delfin");
        Acuaticos.Add("Ballena");
        Acuaticos.Add("Pulpo");

        Animales.AddRange(Carnivoros);
        foreach (Object n in Animales) {
            Console.WriteLine(n.ToString());
        }
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();

        Animales.Clear(); // borar los elementos anteriores de un array
        Console.WriteLine("༻·································༺");

        Animales.AddRange(Acuaticos);
        foreach(Object n in Animales) {
            Console.WriteLine(n);
        } */

        // CONTAINS
        string ? palabra;
        ArrayList Materias = new ArrayList();

        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo Tecnico");
        Materias.Add("Ingles");

        Console.Write("Escriba una materia a buscar: ");
        palabra = Console.ReadLine();
        Console.WriteLine(Materias.Contains(palabra) ? "La materia está disponible" : "La materia no se encontró");
    }
}