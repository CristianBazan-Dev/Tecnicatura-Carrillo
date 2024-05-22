from titulo import titulo 
titulo("Leer números enteros positivos - Imprimir suma de digitos")

num = input("Ingrese un numero: ")

total = 0

for x in num: 
    numero = int(x)
    total += numero
print(total)