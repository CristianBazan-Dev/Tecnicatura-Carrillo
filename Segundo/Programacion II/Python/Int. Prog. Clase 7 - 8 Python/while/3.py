from titulo import titulo 
titulo("Leer números enteros positivos - Buscando el mayor")

num = int(input("Ingrese un numero: "))
mayor = 0; 

while num != 0:  
    if num > mayor: 
        mayor = num
    num = int(input("Ingrese un numero: "))
    pass

print("El mayor numero ingresado es", mayor )