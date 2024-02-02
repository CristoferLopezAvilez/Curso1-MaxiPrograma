using System;

namespace Ejercicio8._4
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b = 9;
           Console.WriteLine("Ingrese un número");
           a = int.Parse(Console.ReadLine());
           positivoNegativoCero(a, ref b);

           Console.WriteLine("El estado del valor "+ a + " es: "+ b);
    
        }
        static void positivoNegativoCero(int n1, ref int n2){
            if(n1 > 0){
                n2 = 1;
            }else if(n1 < 0){
                n2 = -1;

            }else{
                n2 = 0;
            }
        }
    }
}
