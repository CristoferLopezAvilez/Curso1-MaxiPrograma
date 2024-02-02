using System;

namespace Ejercicio3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla
            // “Positivo” si el número es mayor a cero,
             //“Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
            Console.WriteLine("Ingrese un número");
            int N;
            N = int.Parse(Console.ReadLine());
            if(N>0){
                Console.WriteLine("El número es positivo");
            }else if(N<0){
                Console.WriteLine("El número es negativo");
            }else{
                Console.WriteLine("El número es igual a 0");
            }

        }
    }
}
