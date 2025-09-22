def ejer1():
    precio = float(input("Ingrese el precio del producto: "))

    print("Escoja un código de descuento:\n1 = Estudiante\n2 = Empleado\n3 = Cliente frecuente")
    codigo = int(input())

    descuento = 0

    if codigo == 1 or codigo == 2 or codigo == 3:

      if codigo == 1:
        descuento = 0.10
      elif codigo == 2:
        descuento = 0.15
      elif codigo == 3:
        descuento = 0.20
    else:

      print("Código no válido, no se aplicará descuento.")

    precio_final = precio - (precio * descuento)

    if precio > 500 and descuento > 0:

     precio_final = precio_final - (precio * 0.05)

    print(f"El precio final es: {precio_final:.2f}")

def ejer2():
    nota = int(input("Ingrese una nota (0-20): "))

    if nota < 0 or nota > 20:
      print("Error: La nota debe estar entre 0 y 20.")
    else:

      if 0 <= nota <= 10:
        print("Desaprobado")
      elif 11 <= nota <= 13:
        print("Regular")
      elif 14 <= nota <= 17:
        print("Bueno")
      elif 18 <= nota <= 20:
        print("Excelente")

    if nota >= 14 and nota % 2 == 0:
        print("Buen desempeño con nota par")

    if nota % 2 != 0 or nota < 11:
        print("Necesita reforzar")

    raiz = nota ** 0.5
    cubo = nota ** 3

    print(f"Raíz cuadrada: {raiz:.1f}")
    print(f"Potencia al cubo: {cubo}")

ejer1()