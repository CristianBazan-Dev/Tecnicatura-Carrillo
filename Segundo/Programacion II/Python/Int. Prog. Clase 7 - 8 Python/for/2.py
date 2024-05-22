from titulo import titulo 
titulo("Calculadora de numeros positivos")

valores = []

for x in range(0,4): 
    valor = int(input("Ingrese un número positivo: "))
    
    if valor < 0: 
        print("El valor no es positivo. Ingrese otro por favor.")
        valor = int(input("Ingrese un número positivo: "))
    
    valores.append(valor)


suma = valores[0] + valores[1] + valores[2] +  valores[3]
resta = valores[0] - valores[1] - valores[2] -  valores[3]
multiplicacion = valores[0] * valores[1] * valores[2] *  valores[3]
division = valores[0] / valores[1] / valores[2] /  valores[3]

print('La suma da como resultado', suma)
print('La resta da como resultado', resta)
print('La multiplicacion da como resultado', multiplicacion)
print('La division da como resultado', division)