using System;

namespace Ejercicio2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float Totalfacturado, SueldoTotal;
            Totalfacturado = float.Parse(Console.ReadLine());
            SueldoTotal = (Totalfacturado / 100) * 5 + 15000;
            Console.WriteLine("El Sueldo Total es:" + SueldoTotal);
        }
    }
}
