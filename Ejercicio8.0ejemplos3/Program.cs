using System;

namespace Ejercicio8._0ejemplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            //resultado = n1 + n2;
            resultado = sumar(ref n1, n2);


            Console.WriteLine("El Resultado es: " + resultado);
        }
        static int sumar(ref int a, int b){
            int r;
            r = a + b;
            return r;
        }
        static void pedirDatos(ref int j, ref int h){
            Console.WriteLine("Ingrese un número");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            h = int.Parse(Console.ReadLine());
            
        }
    }
}
