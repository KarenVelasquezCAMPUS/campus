Algoritmo de Secuencia de Fibonacci en C#

Este algoritmo en C# está diseñado para realizar diversas operaciones con la secuencia de Fibonacci, una de las secuencias numéricas más conocidas en matemáticas. El programa permite al usuario interactuar con tres funcionalidades principales:

    - Cálculo del n-ésimo Número de Fibonacci: La función CalculateFibonacci (int n) recibe un número entero n y devuelve el n-ésimo número en la secuencia de Fibonacci. Utiliza un enfoque iterativo para calcular el número solicitado.

    - Verificación de Número de Fibonacci: La función IsFibonacci (int num) determina si un número dado num es un número de Fibonacci. Recorre la secuencia hasta encontrar el número o superar el valor dado, retornando un valor booleano que indica si el número está en la secuencia.

    - Generación de los Primeros m Números de Fibonacci: La función FillFibonacci (int m) recibe un número entero m y genera una lista con los primeros m números de la secuencia de Fibonacci. Esta función utiliza un bucle para calcular y almacenar los números en una lista que luego se imprime.

El programa principal (Main) guía al usuario para ingresar los valores necesarios y muestra los resultados correspondientes para cada una de las tres funcionalidades descritas. Primero, solicita el número n y calcula el n-ésimo número de Fibonacci. Luego, pide un número para verificar si es un número de Fibonacci y, finalmente, solicita el valor de m para mostrar los primeros m números de Fibonacci.

Este algoritmo es útil para aplicaciones matemáticas y educativas, facilitando el cálculo, verificación y generación de números en la secuencia de Fibonacci de manera eficiente.