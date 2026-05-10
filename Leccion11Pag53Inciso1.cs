using System;

namespace factorial_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int factorial = 1;

            Console.WriteLine("Ingrese un numero:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial es: " + factorial);
        }
    }
}