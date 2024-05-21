from titulo import titulo 
titulo("Facturación de producto")

iva = 21

cantidad = int(input("Ingrese la cantidad: "))
valor = float(input("Ingrese el valor del producto: "))

subtotal = valor * cantidad 
recargo = (subtotal * iva) / 100
total = subtotal + recargo

print("-" * 20)
print("Subtotal: ", subtotal)
print("-" * 20)
print("IVA: ", iva)
print("-" * 20)
print("Total: ", total)
print("-" * 20)