from titulo import titulo 
titulo("Sumatoria de los numeros entre 0 y 100")


# Suma comun 
suma = 0
for x in range(0,101):
    suma += x
    
print("La suma da como resultado", suma)
    
# Modificación para los multiplos de 3
multiplos_3 = 0
for x in range(0,101):
    if x % 3 == 0:
        # print(x)
        multiplos_3 += x
        

print("La suma total de los multiplos de 3 del 0 al 100 es de", multiplos_3)