from titulo import titulo 
titulo("Detector de mayores de edad")

pregunta = input("Es mayor de 18 años? \n").lower()

if pregunta == 'si': 
    print("Es mayor de edad.")
else:
    print("No es mayor de edad.")

