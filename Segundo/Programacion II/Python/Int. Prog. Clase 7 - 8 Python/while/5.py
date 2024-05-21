from titulo import titulo 
titulo('Autenticador de contraseña')

contraseña = input("Cree su contraseña: ")

ingreso = input("Ingrese su contraseña: ")

if ingreso != contraseña: 
    print("Contraseña incorrecta.")
else: 
    print("¡Bienvenido!")