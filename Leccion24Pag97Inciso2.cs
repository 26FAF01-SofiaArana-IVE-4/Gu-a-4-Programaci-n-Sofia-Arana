using System;

namespace numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Ingrese un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}