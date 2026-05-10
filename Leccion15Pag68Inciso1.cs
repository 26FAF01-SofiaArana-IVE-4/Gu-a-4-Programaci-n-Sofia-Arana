using System;

namespace multiplos_de_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int pares = 0;
            int multiplo = 0;

            for (int i = 1; i <= 20; i++)
            {
                multiplo = i * 7;

                suma = suma + multiplo;

                if (multiplo % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine("La sumatoria es: " + suma);

            Console.WriteLine("Cantidad de multiplos pares: " + pares);
        }
    }
}
