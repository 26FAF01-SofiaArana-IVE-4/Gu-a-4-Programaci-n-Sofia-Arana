using System;

namespace billetes_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int billete = 0;
            int cantidad100 = 0;
            int totalDinero = 0;

            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("Ingrese el valor del billete:");
                billete = Convert.ToInt32(Console.ReadLine());

                if (billete == 100)
                {
                    cantidad100++;
                    totalDinero = totalDinero + billete;
                }
            }

            Console.WriteLine("Cantidad de billetes de 100: " + cantidad100);

            Console.WriteLine("Total de dinero en billetes de 100: " + totalDinero);
        }
    }
}
