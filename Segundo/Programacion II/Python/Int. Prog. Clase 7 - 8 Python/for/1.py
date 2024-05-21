from titulo import titulo 
titulo("Detectando numeros mayores y menores")

valores = []

for x in range(0,5): 
    valor = int(input("Ingrese un valor: "))
    valores.append(valor)

valAnterior = 0
menor = 0
mayor = 0

for valor in valores: 
    if valor < valAnterior: 
        menor = valor 
    elif valor > valAnterior: 
        mayor = valor
    
    valAnterior = valor
        
print(menor, mayor)
