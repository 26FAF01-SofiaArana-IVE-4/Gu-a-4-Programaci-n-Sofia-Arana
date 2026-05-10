using System;

namespace numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int contador = 0;

            Console.WriteLine("Ingrese un numero:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }
    }
}