using System;

namespace Ejercicio8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
        

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                if(par(n)){
                    cont++;
                }
                
            }      
            Console.WriteLine("La cantidad de números pares es: " + cont);     
        }

        static bool par(int n){
            
            if(n % 2 == 0){
                return true;
            }else{
                return false;
            }
        }
    }
}
