from titulo import titulo 
titulo("Eco")

eco = input("Ingrese la palabra a repetir: ")
conteo = 1

while eco != 'salir': 
    print(eco * conteo) 
    eco = input("")
    conteo += 1
    pass