using System;

namespace primos_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorPrimos = 0;
            int suma = 0;

            for (int n = 1; n <= 100; n++)
            {
                int divisores = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        divisores++;
                    }
                }

                if (divisores == 2)
                {
                    contadorPrimos++;
                    suma = suma + n;
                }
            }

            Console.WriteLine("Cantidad de numeros primos: " + contadorPrimos);

            Console.WriteLine("Suma de numeros primos: " + suma);
        }
    }
}
