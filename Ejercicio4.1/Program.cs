using System;

namespace Ejercicio4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, R; 
            Console.WriteLine("Ingrese dos números: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if (A > B){
                R = A - B;
            }
            else if (A == B){
                R = A + B;
            }else {
                R = A * B;
            }
            Console.WriteLine(R);
            
            
        }
    }
}
