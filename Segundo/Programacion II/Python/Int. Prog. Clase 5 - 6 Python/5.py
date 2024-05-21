from titulo import titulo 

num1 = int(input("Ingrese el primer número: "))
num2 = int(input("Ingrese el segundo número: "))

if num2 == 0: 
    print("ERROR. No se puede dividir entre 0.")
else: 
    print(num1 / num2)