using System;

namespace Ejercicio8._0ejemplos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            n2 = int.Parse(Console.ReadLine());

            //resultado = n1 + n2;
            resultado = sumar(n1, n2);


            Console.WriteLine("El Resultado es: " + resultado);
        }
        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }
    }
}
