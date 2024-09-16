Algoritmo de Conteo de Votos por Universidad en Python

Este algoritmo en Python está diseñado para recolectar y analizar los votos de estudiantes sobre la aceptación o rechazo de propuestas en varias universidades. Permite al usuario ingresar datos sobre varias universidades y calcular el resultado de los votos para cada una, así como un resumen general. A continuación, se describen las funcionalidades principales del algoritmo:

    - Entrada de Datos: El programa solicita al usuario que ingrese la cantidad de universidades a evaluar. Luego, para cada universidad, pide el nombre y los votos recibidos. Los votos se ingresan como una cadena de texto con opciones separadas por espacios (A para Aceptar, R para Rechazar, N para Nulo, B para Blanco). El usuario puede terminar la entrada de votos con X o presionando Enter.

    - Contador de Votos: Para cada universidad, el algoritmo cuenta el número de votos para cada opción (A, R, N, B). Luego, imprime el resultado de los votos para esa universidad.

    - Clasificación de Resultados: El algoritmo clasifica el resultado de cada universidad en tres categorías: aceptación (cuando los votos para A son mayores que para R), rechazo (cuando los votos para R superan a los de A), y empate (cuando los votos para A y R son iguales). Se mantiene un conteo de cuántas universidades caen en cada categoría.

    - Resumen Final: Al finalizar, el algoritmo imprime el total de universidades que aceptan, rechazan o tienen un empate basado en los resultados de los votos ingresados.

Este algoritmo es útil para procesos de votación o encuestas en instituciones educativas, proporcionando una manera eficiente de analizar y presentar los resultados de forma clara y organizada.