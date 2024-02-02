using System;

namespace Ejercicio7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicion = 0, maximo = 0;
            int[] numeros = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeros[x] = int.Parse(Console.ReadLine());
                
            }

            for (int x = 0; x < 10; x++)
            {
                if(x == 0){
                    maximo = numeros[x];
                    posicion = x + 1;
                }
                else if(numeros[x] > maximo){
                    maximo = numeros[x];
                    posicion = x + 1;
                }
                
            }
            Console.WriteLine("El número máximo es " + maximo + " que está en la posición " + posicion);
            
        }
    }
}
