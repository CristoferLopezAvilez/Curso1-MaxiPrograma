using System;

namespace Ejercicio2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, C;
            Console.WriteLine("Ingrese un número:");
            N = int.Parse(Console.ReadLine());
            C = N * N * N;
            Console.WriteLine("El resultado es: "+ C);

        }
    }
}
