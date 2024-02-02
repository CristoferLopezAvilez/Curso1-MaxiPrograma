using System;

namespace Ejercicio7._0ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[10];

            double[] muestraMatutina = new double[31];
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];

            int día;
            double temperatura;
            Console.WriteLine("Cargue el resgistro matutino");
            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese día: ");
                dia = int.Parse(Console.ReadLine);
                Console.WriteLine("Ingrese temperatura registrada: ");
                temperatura = double.Parse(Console.ReadLine());

                muestraMatutina[día - 1]
            }
        }
    }
}
