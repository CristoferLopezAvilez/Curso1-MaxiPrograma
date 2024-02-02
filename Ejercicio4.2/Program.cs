using System;

namespace Ejercicio4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe, litros;
            Console.WriteLine("Ingrese el importe de la venta");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500)
              importe *= 0.75F;
            else if(litros > 300)
              importe *= 0.85F;
            else if(litros > 100)
              importe *= 0.90F;

            Console.WriteLine("El importe total es: " + importe);


        }
    }
}
