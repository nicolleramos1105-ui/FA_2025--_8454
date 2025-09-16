using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            Console.Write("\"Nicolle\"");
        }
        static void ejer3()
        {
            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine()); 

            double divi=(double)num1/(double)num2;

            Console.Write("Suma: "+(num1+num2));
            Console.Write("Resta: " + (num1 - num2));
            Console.Write("Multiplicacion: " + (num1 * num2));
            Console.Write("Division: " + (num1 / num2));
        }
        static void ejer4()
        {
            Console.Write("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            double redo = Math.Round(num, 0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1/3d);

            Console.WriteLine("\nRaiz 2: " + raiz2);
            Console.WriteLine("Redondeo: " + redo);
            Console.WriteLine("AL cubo: "+ cubo);
            Console.WriteLine("Raiz cubica: " + raiz3);
        }

        static void ejer5()
        {
            Console.WriteLine("Ingrese un numero: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("\nResto: " + (entero % 2));
            Console.WriteLine("Dividido 3: " + (deci / 3));
        }
        static void ejer6()
        {
        }
    }
}
