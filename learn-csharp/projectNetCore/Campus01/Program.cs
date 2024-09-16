﻿internal class Program
{
    private static void Main(string[] args)
    {
        // [Modificador de Acceso] tipo Identificador;
        int edad = 0;
        string ? nombre;
        string apellido = string.Empty;
        string direccion = "";
        // const double iva = 19.00;
        bool estado = false;

        try{
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine() ?? String.Empty;
            Console.Beep();
            Console.WriteLine("{0} ingrese su apellido", nombre.ToUpper());
            apellido = Console.ReadLine() ?? String.Empty;
            bool estadoEdad = false;
            while (estadoEdad == false){

                try{
                    Console.WriteLine("{0} {1} Ingrese su edad: ", nombre, apellido);
                    edad = Convert.ToInt16(Console.ReadLine());
                    estadoEdad = true;
                }catch(Exception){
                    Console.WriteLine("La edad no puede estar vacía o tener valores de string");
                    Console.ReadKey();
                    for(int i=0; i<=3; i++){
                        Console.Beep();
                    }
                    estadoEdad = false;
                }

            if(edad >= 1 && edad <=11){
                Console.WriteLine("{0} {1} Es un niño", nombre, apellido);
            }else if(edad > 11 && edad <=17){
                Console.WriteLine("{0} {1} Es un adolescente", nombre, apellido);
            }else if(edad > 17 && edad <=59){
                Console.WriteLine("{0} {1} Es mayor de edad", nombre, apellido);
                estado = true;
            }else{
                estado = true;
                Console.WriteLine("{0} {1} Es un adulto mayor", nombre, apellido);
            }
            switch(estado){
                case true:
                    Console.WriteLine("{0} {1} Puede ingresar al evento", nombre, apellido);
                    break;
                default:
                    Console.WriteLine("{0} {1} No puede ingresar al evento", nombre, apellido);
                    break;
            }
            Console.WriteLine("{0} {1} Ingrese su dirección: ", nombre, apellido);
            direccion = Console.ReadLine() ?? String.Empty;

        } 
        } catch (Exception ex) 
        {
            Console.WriteLine("Error al momento de ingresar el dato {0}", ex.Message);
            Console.ReadKey();
        }


    }
}

/* internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Hello, World!"); //no hay salto de linea
        Console.WriteLine("Hola Mundo"); //salto de linea
        Console.ReadKey(); //capturar una tecla, es decir dar a una tecla y se cierra el codigo
        Console.Write(Console.ReadKey().Key); //ver en concola que tecla fue oprimida 

        // VARIABLES
        int edad; //variable entera
        string ? nombre; // el ? es para definirlo como vacio
        string apellido = String.Empty; //
        string direccion = ""; //
        // const double iva = 19.00; //float
        bool estado = false; //booleano
        // Console.WriteLine(estado ? "Ok" : "No");
        //ReadLine es solo para string
        
        try
        {
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine(); 
            Console.WriteLine("{0} ingrese su apellido", nombre);
            apellido = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("{0} {1} Ingrese su edad", nombre,apellido);
            Console.WriteLine($"{nombre} {apellido} Ingrese su edad"); // otro metodo de interpolizar 
            edad = Convert.ToInt16(Console.ReadLine());
            if (edad >= 18){
                Console.WriteLine($"{nombre} {apellido} Es mayor de edad");
            }
            Console.WriteLine($"{nombre} {apellido} Ingrese su Dirección");
            direccion = Console.ReadLine() ?? String.Empty;
            Console.WriteLine(estado ? "Ok" : "No");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al momento de ingresar el dato {0}", ex.Message);
            Console.ReadKey();
        }
        

        // verde es la clase, amarillo es el metodo 
    }
} */