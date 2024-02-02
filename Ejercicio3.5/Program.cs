using System;

namespace Ejercicio3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números 
            //y luego mostrar por pantalla cuáles son mayores a 100.
            int N1, N2, N3, N4;
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            N3 = int.Parse(Console.ReadLine());
            N4 = int.Parse(Console.ReadLine());
            if (N1 > 100){
                Console.WriteLine(N1 + " es mayor a 100");
            }if (N2 > 100){
                Console.WriteLine(N2 + " es mayor a 100");
            }if (N3 > 100){
                Console.WriteLine(N3 + " es mayor a 100");
            }if (N4 > 100){
                Console.WriteLine(N4 + " es mayor a 100");
            }
        }
    }
}
