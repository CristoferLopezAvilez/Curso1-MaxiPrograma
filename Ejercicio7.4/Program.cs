using System;

namespace Ejercicio7._4
{
    class Program
    {
        static void Main(string[] args)
        {
           int art, cantv = 0, max;
          
               Console.WriteLine("Ingrese el número de artículo");
               art = int.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese la cantidad vendida");
               cantv = int.Parse(Console.ReadLine());

             int[] acu = new int[15];
             for (int x = 0; x < 15; x++)
             {
                acu[x] = 0;
             }
            while (art != 0)
            {
              
              acu[art - 1] += cantv;
               
              Console.WriteLine("Ingrese el número de artículo");
              art = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese la cantidad vendida");
              cantv = int.Parse(Console.ReadLine());
            }
            max = 0;
            for (int x = 0; x < 15; x++)
            {
                if (acu[x] > max)
                {
                    max = acu[x];
                    art = x + 1;
                }
                if(acu[x] == 0){
                    Console.WriteLine("El artículo " + (x + 1) + " no registró ventas");
                }
                
            }
            Console.WriteLine("El articulo más vendido es " + art + " con una cantidad vendida de " + max);
            Console.WriteLine("El artículo 10 vendió " + acu[9]);
        }
    }
}
