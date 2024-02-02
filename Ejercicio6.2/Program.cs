using System;

namespace Ejercicio6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conNumeros, conImpares, grupoImparesMaximo = 0, min, conOrdenados = 0;
            double porcentajeImpares, porcentajeMaximo = -1;
            bool banderaOrdenados;
           for (int x = 0; x < 5; x++)
           {
              conNumeros = 0;
              conImpares = 0;
              banderaOrdenados = true;
              n = int.Parse(Console.ReadLine());
              min = n;
              while (n != 0)
            {
                conNumeros++;
                if(n % 2 != 0){
                    conImpares++;
                    if(n <= min){
                        min = n;
                    }else{
                        banderaOrdenados = false; 
                    }
                }
                n = int.Parse(Console.ReadLine());
            }
            porcentajeImpares = conImpares * 100 / conNumeros;
            if(porcentajeImpares > porcentajeMaximo){
                porcentajeMaximo = porcentajeImpares;
                grupoImparesMaximo = x + 1;
            }
            if(banderaOrdenados){
                conOrdenados++;

            }
           }
           Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
           Console.WriteLine("La cantidad de grupos con números ordenados es: " + conOrdenados);
          
        }
    }
}
