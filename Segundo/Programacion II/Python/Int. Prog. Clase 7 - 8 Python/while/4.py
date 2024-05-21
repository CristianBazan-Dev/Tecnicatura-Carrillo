from titulo import titulo 
titulo("Leer números enteros positivos - Imprimir suma de digitos")

num = int(input("Ingrese un numero: "))

conteo = 0

while conteo != num:  
    conteo += 1 
    
    if(conteo == num):
        print(conteo)
        break