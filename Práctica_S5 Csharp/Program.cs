using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey();
        }


        static void ejer1()
        {

            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escoja un código de descuento:\n1 = Estudiante\n2 = Empleado\n3 = Cliente frecuente");
            int codigo = Convert.ToInt32(Console.ReadLine());

            double descuento = 0;

            if (codigo == 1 || codigo == 2 || codigo == 3)
            {
                if (codigo == 1)
                {
                    descuento = 0.10;
                }
                else if (codigo == 2)
                {
                    descuento = 0.15;
                }
                else if (codigo == 3)
                {
                    descuento = 0.20;
                }
            }
            else
            {
                Console.WriteLine("Código no válido, no se aplicará descuento.");
            }

            double precioFinal = precio - (precio * descuento);

            if (precio > 500 && descuento > 0)
            {
                precioFinal = precioFinal - (precio * 0.05);
            }

            Console.WriteLine($"El precio final es: {precioFinal:F2}");
        }

        static void ejer2()
        {
            Console.Write("Ingrese una nota (0-20): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Error: La nota debe estar entre 0 y 20.");
                return;
            }

            switch (nota)
            {
                case int n when (n >= 0 && n <= 10):
                    Console.WriteLine("Desaprobado");
                    break;
                case int n when (n >= 11 && n <= 13):
                    Console.WriteLine("Regular");
                    break;
                case int n when (n >= 14 && n <= 17):
                    Console.WriteLine("Bueno");
                    break;
                case int n when (n >= 18 && n <= 20):
                    Console.WriteLine("Excelente");
                    break;
            }

            if (nota >= 14 && nota % 2 == 0)
            {
                Console.WriteLine("Buen desempeño con nota par");
            }

            if (nota % 2 != 0 || nota < 11)
            {
                Console.WriteLine("Necesita reforzar");
            }

            double raiz = Math.Sqrt(nota);
            double cubo = Math.Pow(nota, 3);

            Console.WriteLine($"Raíz cuadrada: {raiz:F1}");
            Console.WriteLine($"Potencia al cubo: {cubo}");
        }

    }
}
