# ------- Calculadora --------
from titulo import titulo
titulo('Calculadora')

num1 = int(input("Ingrese el primer número: "))
num2 = int(input("Ingrese el segundo número: "))
num3 = int(input("Ingrese el tercer número: "))


# Estas operaciones se pueden realizar de manera dinamica teniendo en cuenta cuál es el mayor en los casos que se requiera obtener resultados naturales positivos o que no se vayan de numeros enteros. Lo interprete de esta manera porque iba más de la mano con lo ejemplificado en el apunte 

suma = num1 + num2 + num3 
resta = num1 - num2 - num3
multiplicacion = num1 * num2 * num3 
division = num1 / num2 / num3

print("La suma da como resultado", suma)
print("La resta da como resultado", resta)
print("La multiplicacion da como resultado", multiplicacion)
print("La division da como resultado", division)