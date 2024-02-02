using System;

namespace Ejercicio5._5
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa que solicite 20 números
            // y luego emitir por pantalla el máximo de los 
           //  números pares y el mínimo de los números impares
           //int n, mayor = 0, menor = 0;
           //for (int x = 0; x < 20; x++)
           //{ 
            //Console.WriteLine("Ingrese un número");
            //n = int.Parse(Console.ReadLine());
            //if(x == 0 && n % 2 == 0){
              //  mayor = n;

            //}else {
             //   if (n > mayor){
               //     mayor = n;
                //}
           // }
            //if (x == 0 && n % 2 == 1){
              //  menor = n;
            //}else {
              //  if (n < menor){
                //    menor = n;
               // }
           // }

       
           //} 
           //Console.WriteLine("El mayor de los pares es: " + mayor);
           //Console.WriteLine("El menor de los impares es: " + menor);

           int n, mayor = 0, menor = 0;
           bool banPar = false, banImpar = false;
           for (int x = 0; x < 20; x++)
           { 
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            if(n % 2 == 0){
                if(banPar == false){
                    mayor = n;
                    banPar = true;
                }
                else if(n > mayor){
                    mayor = n;
                }
            }else {
                if(banImpar == false){
                    menor = n;
                    banImpar = true;
                }else if(n > menor){
                    menor = n;                    
                }
            }
        }
        Console.WriteLine("El mayor de los pares es: " + mayor);
        Console.WriteLine("El menor de los impares es: " + menor);
        }
    }
}
