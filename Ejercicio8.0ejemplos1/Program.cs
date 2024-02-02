using System;

namespace Ejercicio8._0ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte de las funciones
            //Cabecera: 
            //1. Tipo de dato
            //2. Nombre
            //3. Opcional: parámetros
            //Cuerpo
            //1. definición/lógica
            //2. Opcional: retorno de valor o resultado
            int n = devolverUno();
            Console.WriteLine("Fin del programa: " + n);
        }
        static int devolverUno(){
            int numero = 1;
            return numero;
        }
    }
}
