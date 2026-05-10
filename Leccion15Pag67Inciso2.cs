using System;

namespace billetes_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int billete = 0;
            int contador100 = 0;
            int totalDinero = 0;
            int cantidadBilletes = 0;

            Console.WriteLine("Ingrese la cantidad de billetes:");
            cantidadBilletes = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidadBilletes; i++)
            {
                Console.WriteLine("Ingrese el valor del billete:");
                billete = Convert.ToInt32(Console.ReadLine());

                if (billete == 100)
                {
                    contador100++;
                    totalDinero = totalDinero + billete;
                }
            }

            Console.WriteLine("Cantidad de billetes de 100: " + contador100);

            Console.WriteLine("Total de dinero en billetes de 100: " + totalDinero);
        }
    }
}