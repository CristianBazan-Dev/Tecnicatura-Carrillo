from titulo import titulo 
titulo('Calculadora de sueldo')

horas = float(input("Ingrese las horas trabajadas: "))
valor = float(input("Ingrese el valor de sus horas: "))

print("Deberá cobrar un total de $", horas * valor)
