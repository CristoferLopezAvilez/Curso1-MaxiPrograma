using System;

namespace Ejercicio5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                if(n % x == 0){
                    cont++;
                }
                            
            } 
            if(cont == 2){
                Console.WriteLine("El número " + n + " es primo");

            } else{
                Console.WriteLine(n + " no es primo");
            }
        }
    }
}
