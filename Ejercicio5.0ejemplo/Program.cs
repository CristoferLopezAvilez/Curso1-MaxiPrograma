using System;

namespace Ejercicio5._0ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //for(int x = 0; x < 5; x++){
                //Console.WriteLine("Hello World!");

           // }
           //int n, suma = 0, prom;
           //for (int x = 0; x < 5; x++){
            //Console.WriteLine("Ingrese un número");
            //n = int.Parse(Console.ReadLine());
            //suma += n;
           //}
          // prom = suma / 5;
           //Console.WriteLine("El promedio es: " + prom);
          
          int n, cont =0;
          Console.WriteLine("Ingresa un número: ");
          n = int.Parse(Console.ReadLine());
          while (n !=0)
          {cont++;
          Console.WriteLine("Ingresa un número: ");
          n = int.Parse(Console.ReadLine());
            
          }
          Console.WriteLine("Se ingresaron " + cont + " números");

            
           }
        }
    }