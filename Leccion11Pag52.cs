using System;

namespace estacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cajones = 20;

            while (cajones > 0)
            {
                Console.WriteLine("Cajones disponibles: " + cajones);

                cajones--;
            }

            Console.WriteLine("************Ya no hay cajones libres*********");
        }
    }
}