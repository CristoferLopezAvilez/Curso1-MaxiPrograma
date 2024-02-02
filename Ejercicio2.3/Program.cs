using System;

namespace Ejercicio2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float Km, V, T;
            Console.WriteLine("Ingrese los Kilométros entre las dos ciudades y la veocidad promedio del vehículo");
            Km = float.Parse(Console.ReadLine());
            V = float.Parse(Console.ReadLine());
            T = Km / V;
            Console.WriteLine("El tiempo aproximado en que el vehículo llegará es:" + T.ToString("0.00"));
        

        }
    }
}
