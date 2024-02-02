using System;

namespace Ejercicio3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo del 
            //importe de la compra realizada según los siguientes valores:
//Si el importe es menor a ARS 1000, no hay descuento.
//Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//Si el importe es ARS 5000 o más, aplica un descuento del 18%.
//Hacer un programa para ingresar un importe de venta
// y luego muestre por pantalla el importe final con el descuento que corresponda.
            float ImpV, T;
            Console.WriteLine("Importe de la venta: ");
            ImpV = float.Parse(Console.ReadLine());
            if(ImpV>=1000 && ImpV<5000){
                T = ImpV * 0.9F;
            }else if (ImpV<1000){
                T = ImpV * 1F;
            }else {
                T = ImpV * 0.82F;
            }
            Console.WriteLine("El importe final de la venta es " + T);
        }
    }
}
