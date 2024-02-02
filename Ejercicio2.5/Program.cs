using System;

namespace Ejercicios2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, P;
        
            Console.WriteLine("Ingrese las 3 notas del alumne");
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            N3 = int.Parse(Console.ReadLine());
            P = (N1 + N2 + N3) / 3;
            Console.WriteLine("El promedio final es:" + P);

        }
    }
}
