import tkinter as tk 

root = tk.Tk() 
root.title("Alta GUI")
root.geometry("1920x1080")
root["bg"] = "#222"

nombre = ""

def boton_click():
    value = entry.get()
    label.config(text="¡Hola " + value + "!")


label = tk.Label(root, text="Presiona el boton")
label.pack(pady=50) 

canvas = tk.Canvas(root, width=400, height=300, background="#222")
canvas.pack()

entry = tk.Entry(root) 
canvas.create_window(200, 140, window=entry)



button = tk.Button(root, text="Click aqui", command=boton_click)

button.pack(pady=20)

root.mainloop()