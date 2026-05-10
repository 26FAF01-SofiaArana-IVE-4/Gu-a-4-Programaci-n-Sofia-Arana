using System;

namespace while_no_se_cumpla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monedas = 0;

            Console.WriteLine("Ingrese la cantidad de monedas:");
            monedas = Convert.ToInt32(Console.ReadLine());

            while (monedas < 350)
            {
                Console.WriteLine("Nivel 5 bloqueado");

                Console.WriteLine("Ingrese nuevamente la cantidad de monedas:");
                monedas = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Nivel 5 desbloqueado");
        }
    }
}