using System;

namespace Ejercicio7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int acu;
            float promedio;
            acu = 0;
            int[] numeros = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número");
                numeros[x] = int.Parse(Console.ReadLine());
                
            }
            
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }
            promedio = acu / 10;
            Console.WriteLine("El promedio es: " + promedio);

            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > promedio){
                    Console.WriteLine("El "+ numeros[x] + " es mayor al promedio");
                }
            }
        }
    }
}
