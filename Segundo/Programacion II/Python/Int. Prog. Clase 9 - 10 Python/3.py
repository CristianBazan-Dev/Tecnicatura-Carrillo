from titulo import titulo 
titulo("Promedio de positivos y suma de negativos")

# Disculpe profe acá me dio vagancia agregar 6 variables así que clave un append bien rabioso 
cantidad = 6
valores = []

for x in range(0, cantidad):
    valor = int(input("Ingrese un valor: "))
    valores.append(valor)
    

suma = 0

cantidad_positivos = 0
promedio = 0

for valor in valores: 
    if valor < 0: 
        suma += valor 
    elif valor > 0: 
        cantidad_positivos += 1
        promedio += valor 

promedio = promedio / cantidad_positivos

print("La suma de los negativos es", suma)
print("El promedio de los positivos es", promedio)
        