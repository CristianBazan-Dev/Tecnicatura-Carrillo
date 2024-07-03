import tkinter as tk
from tkinter import messagebox


def submit_person():
    # Obtener los valores ingresados por el usuario para la persona
    nombre = entry_nombre.get()
    apellido = entry_apellido.get()
    edad = entry_edad.get()
    telefono = entry_telefono.get()
    edad = entry_edad.get()
    
    # Verificar si los campos están vacíos
    if not nombre or not edad:
        messagebox.showerror("Error", "Por favor, completa todos los campos para la persona.")
        return
    
    # Verificar si la edad es un número entero
    try:
        edad = int(edad)
    except ValueError:
        messagebox.showerror("Error", "La edad debe ser un número entero.")
        return
    
    # Mostrar los datos ingresados por la persona
    messagebox.showinfo("Datos de la Persona", f"Nombre:{nombre} Apellido: {apellido} Telefono: {telefono} Edad: {edad}")

def submit_profession():
    # Obtener los valores ingresados por el usuario para la profesión

    
    profesion = entry_profesion.get()
    lugar_trabajo = entry_lugar_trabajo.get()

    
    # Verificar si los campos están vacíos
    if not profesion or not lugar_trabajo:
        messagebox.showerror("Error", "Por favor, completa todos los campos para la profesión.")
        return
    
    # Mostrar los datos ingresados para la profesión
    messagebox.showinfo("Datos de la Profesión",  f" Profesión: {profesion}\nLugar de Trabajo: {lugar_trabajo}")

# Crear la ventana principal
root = tk.Tk()
root.title("Datos Personales y Profesionales")

# Formulario para los datos de la persona
label_nombre = tk.Label(root, text="Nombre:")
label_nombre.grid(row=0, column=0, padx=10, pady=5)
entry_nombre = tk.Entry(root)
entry_nombre.grid(row=0, column=1, padx=10, pady=5)

label_apellido = tk.Label(root, text="Apellido:")
label_apellido.grid(row=1, column=0, padx=10, pady=5)
entry_apellido = tk.Entry(root)
entry_apellido.grid(row=1, column=1, padx=10, pady=5)


label_telefono = tk.Label(root, text="Telefono:")
label_telefono.grid(row=2, column=0, padx=10, pady=5)
entry_telefono= tk.Entry(root)
entry_telefono.grid(row=2, column=1, padx=10, pady=5)

label_edad = tk.Label(root, text="Edad:")
label_edad.grid(row=3, column=0, padx=10, pady=5)
entry_edad = tk.Entry(root)
entry_edad.grid(row=3, column=1, padx=10, pady=5)

submit_person_button = tk.Button(root, text="Enviar Datos de la Persona", command=submit_person)
submit_person_button.grid(row=4, columnspan=2, padx=10, pady=10)

# Formulario para los datos de la profesión
label_profesion = tk.Label(root, text="Profesión:")
label_profesion.grid(row=5, column=0, padx=10, pady=5)
entry_profesion = tk.Entry(root)
entry_profesion.grid(row=5, column=1, padx=10, pady=5)

label_lugar_trabajo = tk.Label(root, text="Lugar de Trabajo:")
label_lugar_trabajo.grid(row=6, column=0, padx=10, pady=5)
entry_lugar_trabajo = tk.Entry(root)
entry_lugar_trabajo.grid(row=6, column=1, padx=10, pady=5)

submit_profession_button = tk.Button(root, text="Enviar Datos de la Profesión", command=submit_profession)
submit_profession_button.grid(row=7, columnspan=2, padx=10, pady=10)

# Ejecutar el bucle principal
root.mainloop()
