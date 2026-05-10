using System;

namespace numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Ingrese un numero:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}