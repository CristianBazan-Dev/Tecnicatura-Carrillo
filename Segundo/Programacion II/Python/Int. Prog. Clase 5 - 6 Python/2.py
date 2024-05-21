from titulo import titulo 

titulo("Calculadora IMC")

peso = float(input("Ingrese su peso: "))
altura = float(input("Ingrese su altura: "))


imc = peso / (altura ** 2)

print("Su índice de masa corporal es de", imc)