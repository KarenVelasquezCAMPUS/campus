using System;
using System.Collections.Generic;

class Program 
{
    // 1. Escriba un programa que reciba como entrada un número entero n, y entregue como salida el nésimo número de Fibonacci:
    static int CalculateFibonacci(int n) 
    {
        int a = 0, b = 1;
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    // 2. Escriba un programa que reciba como entrada un número entero e indique si es o no un número de Fibonacci:
    static bool IsFibonacci(int num)
    {
        int a = 0, b = 1;
        while (a < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == num;
    }

    // 3. Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número ingresado por el usuario:
    static List<int> FillFibonacci(int m)
    {
        List<int> fibonacci = new List<int>();
        int a = 0, b = 1;
        for (int i = 0; i < m; i++)
        {
            fibonacci.Add(a);
            int temp = a;
            a = b;
            b = temp + b;
        }
        return fibonacci;
    }

    static void Main(string[] args)
    {
        // Consulta al usuario del número n punto uno
        Console.Write("Ingresa numero entero: ");
        int n = int.Parse(Console.ReadLine());
        // Solución punto número uno
        int nFibonacci = CalculateFibonacci(n);
        Console.WriteLine($"El numero ingresado {n} en numero Fibonacci es: {nFibonacci}");

        // Consulta al usuario del número y punto uno
        Console.Write("Ingresa numero entero: ");
        int y = int.Parse(Console.ReadLine());
        // Solucion punto número dos 
        if (IsFibonacci(y))
        {
            Console.WriteLine($"{y} es un numero Fibonacci");
        }
        else
        {
            Console.WriteLine($"{y} no es un numero Fibonacci");
        }

        // Consulta al usuario del número m punto tres
        Console.Write("Ingresa el valor de m: ");
        int m = int.Parse(Console.ReadLine());
        // Solución punto número tres
        List<int> firstFibonacci = FillFibonacci(m);
        Console.WriteLine($"Los primeros {m} numeros Fibonacci son: {string.Join(", ", firstFibonacci)}");
    }
}