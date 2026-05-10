using System;

namespace cuenta_regresiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorPrimos = 0;
            int contadorPares = 0;

            for (int n = 300; n >= 1; n--)
            {
                Console.WriteLine(n);

                if (n % 2 == 0)
                {
                    contadorPares++;
                }

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
                }
            }

            Console.WriteLine("Cantidad de numeros primos: " + contadorPrimos);

            Console.WriteLine("Cantidad de numeros pares: " + contadorPares);
        }
    }
}