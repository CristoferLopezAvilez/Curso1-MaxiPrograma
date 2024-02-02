using System;

namespace Ejercicio4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. 
            //Luego analizar e informar por pantalla si los mismos 
            //se encuentran ordenados de forma decreciente 
            int a, b, c, d;
            int cont = 0;
              Console.WriteLine("Ingrese el primer número");
              a = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese el segundo número");
              b = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese el tercer número");
              c = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese el cuarto número");
              d = int.Parse(Console.ReadLine());

              if (a > b)
              cont++;
              if (b > c)
               cont++;
              if (c > d)
               cont++;
              if (cont == 3)
               Console.WriteLine("Están ordenados de forma decreciente");
               else
               Console.WriteLine("No estan ordenados");
               //if (a > b && b > c && c > d)
                //Console.WriteLine("Están ordenados de forma decreciente");
                //else 
                //Console.WriteLine("No estan ordenados");
            
        }
    }
}
