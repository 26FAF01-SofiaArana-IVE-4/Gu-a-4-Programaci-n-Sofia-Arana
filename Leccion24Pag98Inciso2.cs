using System;

namespace cuenta_regresiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int suma = 0;

            Console.WriteLine("Ingrese un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine(i);

                suma = suma + i;
            }

            Console.WriteLine("La suma es: " + suma);
        }
    }
}
