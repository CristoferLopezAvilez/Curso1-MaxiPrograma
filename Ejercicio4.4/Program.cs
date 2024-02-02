using System;

namespace Ejercicio4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar tres números y
             //emitir un cartel aclaratorio si la suma de los dos primeros
              //es mayor al producto del segundo con el tercero.
              int a, b, c;
              int s, p;
              Console.WriteLine("Ingrese el primer número");
              a = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese el segundo número");
              b = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese el tercer número");
              c = int.Parse(Console.ReadLine());

              s = a + b;
              p = b * c;
              if (s > p)
               Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");

        }
    }
}
