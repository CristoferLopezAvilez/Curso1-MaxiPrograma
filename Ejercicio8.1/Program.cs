using System;

namespace Ejercicio8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int art, cantv, montototal;
            Console.WriteLine("Ingrese el precio del artículo");
            art = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantv = int.Parse(Console.ReadLine());

            montototal = producto(art, cantv);

            Console.WriteLine("El total a pagar es: " + montototal);
        }

        static int producto(int a, int b){
            int resultado;
            resultado = a * b;
            return resultado;
        }
    }
}
