using System;

namespace Ejercicio3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos 
            //y luego mostrar por pantalla el menor de ellos.
            int N1, N2, N3, N4;
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            N3 = int.Parse(Console.ReadLine());
            N4 = int.Parse(Console.ReadLine());
            if(N1 < N2 && N1 < N3 & N1 < N4){
                Console.WriteLine("El menor es: " + N1);
            } else if(N2 < N3 && N2 < N4){
                Console.WriteLine("El menor es: " + N2);
            } else if (N3 < N1 && N3 < N2 && N3 < N4){
                Console.WriteLine("El menor es: " + N3);
            } else if (N4 < N1 && N4 < N2 && N4 < N3){
                Console.WriteLine("El menor es: "+ N4);
            
            }


           
        }
    }
}
