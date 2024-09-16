# suma de divisores
def plusowndivisors(n):
    plus = 1 
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            plus += i
            if n // i != i:
                plus += n // i
    return plus

# rangos
def fiendlynumbers(startrange, endrange):
    friendly = []
    for i in range(startrange, endrange + 1):
        plus_i = plusowndivisors(i)
        if plus_i > i and plus_i <= endrange and plusowndivisors(plus_i) == i:
            friendly.append((i, plus_i))
    return friendly

# Definir rango inicial y final
startrange = 1000
endrange = 1500
friendlypairs = fiendlynumbers(startrange, endrange)

# print info
print("Pares de números amigos en el rango {}-{}:".format(startrange, endrange))
for pair in friendlypairs:
    print(pair)