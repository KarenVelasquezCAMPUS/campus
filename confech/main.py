# consultar al usuario la cantidad de universidades
nuniversidades = int(input("Ingrese la cantidad de universidades: "))

# contadores
aceptar_count = 0
rechazar_count = 0
empate_count = 0

# nombre y votos de cada universidad
for i in range(nuniversidades):
    nameuniversidad = input(f"Ingrese el nombre de la Universidad {i + 1}: ")
    votos = input(f"Ingrese los votos de los alumnos el cual tiene las opciones: A para Aceptar, R para Rechazar, N para Nulo, B para Blanco, separados por espacios, con mayusculas y sin comas, si quiere terminar termine con X o con enter: ").split()

# calcular el total de votos
    aceptar = votos.count('A')
    rechazar = votos.count('R')
    nulo = votos.count('N')
    blanco = votos.count('B')
    print(f"Votos para {nameuniversidad}: Aceptar: {aceptar}, Rechazar: {rechazar}, Nulo: {nulo}, Blanco: {blanco}")

# aceptar, reachazar o empate de todas las Universidades
    if aceptar > rechazar:
        aceptar_count += 1
    elif rechazar > aceptar:
        rechazar_count += 1
    else:
        empate_count += 1

# print resultado total de todas las Universidades
print(f"Total de universidades que aceptan: {aceptar_count}")
print(f"Total de universidades que rechazan: {rechazar_count}")
print(f"Total de universidades con empate: {empate_count}")