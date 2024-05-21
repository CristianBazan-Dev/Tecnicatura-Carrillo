from titulo import titulo 
titulo("Factoriales de numero entero positivo")

num = int(input("Ingrese el numero: "))

factorial = 1

if num > 0: 
    for x in range(1, num + 1): 
       factorial = factorial * x
        
print(factorial)