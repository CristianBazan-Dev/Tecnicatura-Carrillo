from titulo import titulo
titulo("Cantidad a invertir")


cantidad = float(input("Cantidad a invertir: "))
interes_anual = float(input("Interes anual: "))
años = int(input("Años a invertir: "))

porcentaje = (cantidad * interes_anual) / 100
cantidad_anual = cantidad + porcentaje 
capital_obtenido = round(cantidad_anual * años)

print("Su capital obtenido rondará los", capital_obtenido)