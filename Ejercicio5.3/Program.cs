using System;

namespace Ejercicio5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, acu = 0, cont = 0, prom;
            for(int x = 0; x < 20; x++){
                Console.WriteLine("Ingrese la edad: ");
                e = int.Parse(Console.ReadLine());
                if( e > 18){
                    acu += e;
                    cont++;
                }                
            }
            prom = acu / cont;
            Console.WriteLine("El promedio es: " + prom);
            
        }
    }
}
