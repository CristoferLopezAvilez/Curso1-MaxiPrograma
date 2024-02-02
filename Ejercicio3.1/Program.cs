using System;

namespace Ejercicio3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar un número y 
            // luego se emita por pantalla un cartel aclaratorio 
            // si “Es mayor a 10” o “No es mayor a 10”.
            Console.WriteLine("Ingrese un número");
            int N;
            N = int.Parse(Console.ReadLine());
            if(N > 10){
                Console.WriteLine("El número es mayor a 10");
                
            }else{
                Console.WriteLine("El número no es mayor a 10");
            }
            

        }
    }
}
