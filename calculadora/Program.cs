using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, resultado; 
                      
            Console.WriteLine("Ingrese un número:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 / n2;
            Console.WriteLine("El resultado es:"+ resultado);


        }
    }
}
