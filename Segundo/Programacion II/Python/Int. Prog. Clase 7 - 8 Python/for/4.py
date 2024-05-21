from titulo import titulo 
titulo("Apertura de caja de ahorros")

# Interes fijo, no queda claro si ha de ser exponencial. En ese caso, se agregaría al for una multiplicación por el valor del año actual 
interes_anual = 4

cantidad_depositada = float(input("Ingrese la cantidad de la caja: "))
porcentaje = (cantidad_depositada * 4) / 100
cantidad_anual = cantidad_depositada + porcentaje 

for x in range(1, 4): 
    print("En el año", x, "obtendrá", cantidad_anual * x)