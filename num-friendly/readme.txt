Algoritmo para Encontrar Pares de Números Amigos en un Rango en Python

Este algoritmo, implementado en Python, está diseñado para identificar pares de números amigos dentro de un rango específico. Los números amigos, o números amistosos, son pares de números en los que cada número es la suma de los divisores propios del otro.

El algoritmo consta de dos partes principales:

    - Suma de Divisores Propios: La función plusowndivisors (n) calcula la suma de los divisores propios de un número n, excluyendo el propio número. Esto se realiza mediante una iteración hasta la raíz cuadrada de n, sumando tanto los divisores menores como los complementarios.

    - Encuentra Números Amigos: La función fiendlynumbers(startrange, endrange) utiliza la función anterior para encontrar pares de números amigos dentro de un rango definido por startrange y endrange. Para cada número en el rango, verifica si es parte de un par de números amigos y los almacena en una lista si cumple con las condiciones.

Al ejecutar el código, se definen los rangos de búsqueda y se generan los pares de números amigos dentro de ese intervalo. Los resultados se imprimen para que el usuario pueda ver qué pares cumplen con la propiedad de números amigos.

Este algoritmo es útil en matemáticas recreativas y en la teoría de números, proporcionando una manera eficiente de identificar estos interesantes pares numéricos en un rango dado.