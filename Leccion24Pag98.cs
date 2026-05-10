using System;

namespace suma_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            for (int n = 1; n <= 50; n++)
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
                    suma = suma + n;
                }
            }

            Console.WriteLine("La suma de los numeros primos es: " + suma);
        }
    }
}