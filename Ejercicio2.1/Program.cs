using System;

namespace Ejercicio2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, R;            
            Console.WriteLine("Ingrese dos números por favor");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            R = n1 + n2;
            Console.WriteLine("El resultado es:" + R);

        }
    }
}
