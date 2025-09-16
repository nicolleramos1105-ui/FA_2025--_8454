import math
from re import M


def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, Bienvenido a FA de {carrera}")

def ejer2():
    print("\"Nicolle\"")

def ejer3():
    num1 = int(input("Ingrese número 1: "))
    num2 = int(input("Ingrese número 2: "))

    print("\nSuma: ", (num1+num2))
    print("Resta: ", (num1-num2))
    print("Multiplicación: ", (num1*num2))
    print("División: ", (num1/num2))

def ejer4():
    num = float(input("Ingrese un número decimal: "))

    raiz2 =math.sqrt(num)
    redo = round(num, 0)
    cubo = math.pow(num, 3)
    raiz3 = math.pow(num, 1/3)

    print("\nRaiz 2: ", raiz2)
    print("Redondeado: ", redo)
    print("Al cubo: ", cubo)
    print("Raiz 3: ", raiz3)
def ejer5():
    num = input("Ingrese un número: ")

    entero = int(num)
    deci = float(num)

    print("\nResto: ", entero % 2)
    print("Dividido 3: ", deci / 3)
ejer3()