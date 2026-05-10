using System;

namespace multiplos_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Ingrese un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(numero * i);
            }
        }
    }
}