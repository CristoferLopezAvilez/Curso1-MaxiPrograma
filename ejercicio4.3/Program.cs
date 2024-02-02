using System;

namespace ejercicio4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int memoria, procesador, disco;
            float monto = 0;
            Console.WriteLine("Ingrese el número de memoria: ");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número del procesador: ");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese si extiende el disco o no: ");
            disco = int.Parse(Console.ReadLine());
            //monto = int.Parse(Console.ReadLine());

            switch (procesador){
                case 1: 
                  switch (memoria)
                  {case 1: 
                    monto = 800;
                    break;
                   case 2: 
                     monto = 900;
                     break;
                   case 3: 
                      monto = 1000;
                      break;
                  }
                break;
                case 2: 
                  switch (memoria)
                {case 1: 
                   monto = 900;
                   break;
                case 2: 
                   monto = 1000;
                   break;
                case 3: 
                    monto = 1400;
                    break;
                }
                break;
                case 3: 
                switch (memoria)
                {case 1: 
                   monto = 1200;
                   break;
                case 2: 
                   monto = 1400;
                   break;
                case 3: 
                    monto = 2000;
                    break;
                }
                break;
                

            }
            if (disco ==1){
              monto = monto + 300;
            }

            Console.WriteLine("El precio final de la compu es: "+ monto);
                
            
            

                

                


            
            

        }
    }
}
