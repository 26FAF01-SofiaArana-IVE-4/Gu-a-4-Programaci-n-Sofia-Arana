using System;

namespace feria_boletos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adultos = 0;
            int niños = 0;
            int totalBoletos = 0;
            int totalDinero = 0;

            Console.WriteLine("Ingrese la cantidad de boletos de adulto:");
            adultos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de boletos de niño:");
            niños = Convert.ToInt32(Console.ReadLine());

            totalBoletos = adultos + niños;

            totalDinero = (adultos * 15) + (niños * 10);

            Console.WriteLine("Total de boletos vendidos: " + totalBoletos);

            Console.WriteLine("Total de dinero cobrado: " + totalDinero);
        }
    }
}