using System;

namespace Ejercicio6._2
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, cont, contlista;
           contlista = 0;
           cont = 0;
           Console.WriteLine("Ingrese un número");
           n = int.Parse(Console.ReadLine());
           while (n > 0)
           {
            
            cont = 0;
            contlista++;
            while (n != 0 && n > 0)
            {
               cont++; 
               Console.WriteLine("Ingrese otros números");
               n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La lista " + contlista + " tiene " + cont + " números");
            Console.WriteLine("Ingrese otros números");
            n = int.Parse(Console.ReadLine());
           }
           
                    

                    
                   

                    
                    
                    

        }
    }
}
