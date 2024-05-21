from titulo import titulo 
titulo("Leer números enteros positivos")

num = int(input("Ingrese un numero: "))
total = 0; 

while num != 0:  
    if num > 0: 
        total += num 
    num = int(input("Ingrese un numero: "))
    pass

print("El total es", total )