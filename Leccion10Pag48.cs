using System;

namespace cuponera_peluqueria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sellos = 0;

            Console.WriteLine("Ingrese la cantidad de sellos:");
            sellos = Convert.ToInt32(Console.ReadLine());

            while (sellos < 8)
            {
                Console.WriteLine("Aun no obtiene el corte gratis");

                Console.WriteLine("Ingrese nuevamente la cantidad de sellos:");
                sellos = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Corre tienes un corte de cabello gratis");
        }
    }
}