from titulo import titulo 
titulo("Validación de números")

num1 = input("Ingrese el primer numero: ")
num2 = input("Ingrese el segundo numero: ")

num1EsNumero = True
num2EsNumero = True

for x in "abcdefghijklmnñopqrstuv":
    for y in num1: 
        if x == y: 
            num1EsNumero = False

    for z in num2: 
        if x == z:
         num2EsNumero = False
        
if num1EsNumero == False: 
    print("El primer dato ingresado no es un número. Intentar de nuevo.")
elif num2EsNumero == False: 
    print("El segundo dato ingresado no es un número. Intentar de nuevo.")
else: 
    num1 = int(num1)
    num2 = int(num2)
    
    if num2 == 0: 
        print("No se puede realizar una división entre 0")
    else: 
        print("El resultado de la division es", num1 / num2)

