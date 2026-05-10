using System;

namespace suma_hasta_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int suma = 0;

            while (num != 9)
            {
                Console.WriteLine("Ingrese un numero:");
                num = Convert.ToInt32(Console.ReadLine());

                suma = suma + num;
            }

            Console.WriteLine("La suma total es: " + suma);
        }
    }
}