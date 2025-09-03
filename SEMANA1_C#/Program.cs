using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey();
        }

        static void ejer1()
        {
            string nombre, carrera; //declarando variables

            Console.Write("Ingrese su nombre: ");
            nombre= Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, Bienvenido al curso de FA de la carrera {carrera}");
        }
        static void ejer2()
        {
            string nombre;
            Console.Write($"\"{nombre}\"");
        }
        static void ejer3()
        {
        }
        static void ejer4()
        {
        }

        static void ejer5()
        {
        }
        static void ejer6()
        {
        }
    }
}
