using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static float num1 = 0, num2 = 0, resultado = 0; // Variables globales a la clase Program

        static void SolicitarDatos()
        {
            Console.WriteLine("Digite el primer numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero:");
            num2 = float.Parse(Console.ReadLine());
        }

        static void suma()
        {
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }

        static void resta(float n1, float n2)
        {
            resultado = n1 - n2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
        }

        static float multiplicar()
        {
            return num1 * num2;
        }

        static float dividir(float n1, float n2)
        {
            if (n2 != 0)
            {
                return n1 / n2;
            }
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;  // Retorna 0 en caso de división por cero
        }

        static void menu()
        {
            int opcion; // Variable local al metodo menu
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Digite una opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    SolicitarDatos();
                    suma();
                    break;
                case 2:
                    SolicitarDatos();
                    resta(num1, num2);
                    break;
                case 3:
                    SolicitarDatos();
                    Console.WriteLine("El resultado de la multiplicacion es: " + multiplicar());
                    break;
                case 4:
                    SolicitarDatos();
                    Console.WriteLine("El resultado de la division es: " + dividir(num1, num2));
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
        static void Main(string[] args)
        {
            menu();
        }
        
    }
}
