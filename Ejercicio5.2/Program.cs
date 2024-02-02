using System;

namespace Ejercicio5._2
{
    class Program
    {
        static void Main(string[] args)
        {
         int n, mayor = 0;
             for(int x = 0; x < 10; x++)
           {             
             Console.WriteLine("Ingrese el número");
             n = int.Parse(Console.ReadLine());
             if(x == 0){
                mayor = n;
             }else {
                if (mayor < n){
                    mayor = n;
                }
             }
           }
           Console.WriteLine("El mayor es: " + mayor);
        }
    }
}
