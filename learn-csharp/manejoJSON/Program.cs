using ManejoJson;
internal class Program
{
    private static void Main(string[] args)
    {
        Controlador controller = new Controlador();
        bool isActive = false;
        int opc = 0;
        do{
            Console.WriteLine("1. Crear Registro\n 2. Salir");
            opc = Convert.ToInt16(Console.ReadLine());
            switch (switch_on) {
                case 1: 
                    controller.AddInfo();
                    break;
                case 2: 
                    isActive = false;
                    break;
                default:
                    break;
            }
        } while (isActive);
    }
}