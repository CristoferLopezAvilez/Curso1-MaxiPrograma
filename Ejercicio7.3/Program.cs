using System;

namespace Ejercicio7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra, letra1, letra2;
            int indice;
            char[] cadena = new char[50];
            indice = 0;
            Console.WriteLine("Ingrese letra por letra hasta completar la frase. Termina con un '.'");
            letra = char.Parse(Console.ReadLine());

            while (letra != '.' && indice < 50)
            {
                cadena[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
                
            }
            cadena[indice] = '\0';

            indice = 0;

            while (cadena[indice] != '\0')
            {
                Console.WriteLine(cadena[indice]);
                indice++;
            }     

            indice = 0;
            Console.WriteLine("Ingrese la letra que desea cambiar");
            letra1 = char.Parse(Console.ReadLine());
            Console.Write("Ingrese la letra por la que desea reemplazar");
            letra2 = char.Parse(Console.ReadLine());

            while (cadena[indice] != '\0')
            {
                if(cadena[indice] == letra1){
                    cadena[indice] = letra2;
                }
                indice++;
            }
            indice = 0;
             while (cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
            }  


        }
    }
}
