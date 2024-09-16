using System;

class Program
{
    static int RussianMultiplication(int multiplier, int multiplying)
    {
        int answer = 0;
        while (multiplier > 0)
        {
            if (multiplier % 2 != 0)
            {
                answer += multiplying;
            }
            multiplier = multiplier / 2;
            multiplying = multiplying * 2;
        }
        return answer;
    }

    static void Main(string[] args)
    {   
        // Consulta al usuario de multiplicador 
        Console.Write("Ingrese el multiplicador: ");
        int multiplier = int.Parse(Console.ReadLine());

        // Consulta al usuario de multiplicando
        Console.Write("Ingrese el multiplicando: ");
        int multiplying = int.Parse(Console.ReadLine());
        int product = RussianMultiplication(multiplier, multiplying);

        // Imprime el resultado
        Console.WriteLine("El resultado es: " + product);
    }
}