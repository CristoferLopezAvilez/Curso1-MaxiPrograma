using System;

namespace Ejercicio6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese el número");
                n = int.Parse(Console.ReadLine());
                cont = 0;

                for (int y = 1; y <= n; y++)
                {
                    if(n % y == 0){
                        cont++;
                    }
                                        
                }
                if(cont <= 2){
                    Console.WriteLine("El número ingresado es primo");
                }else{
                    Console.WriteLine("No es primo");
                }
                
                
            }
        }
    }
}
