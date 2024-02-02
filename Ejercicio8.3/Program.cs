using System;

namespace Ejercicio8._3
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, cont = 0, acu = 0, promedio;
           Console.WriteLine("Ingrese un número");
           n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                
                if(primo(n)){
                    cont++;
                    acu+= n;
                }
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acu / cont;
            Console.WriteLine("El promedio es: " + promedio);
        }

        static bool primo(int a){
            int a, cont = 0;
            for (x = 1; x <= a; x++){
            
                
                if(a % x == 0){
                    cont++;
                }
                if(cont == 2){
                    return true;
                }else{
                    return false;
                }
                
            }

        }
    }
}
