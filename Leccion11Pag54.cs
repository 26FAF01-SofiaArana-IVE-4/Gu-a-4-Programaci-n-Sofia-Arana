using System;

namespace suma_entre_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int menor = 0;
            int mayor = 0;
            int suma = 0;

            Console.WriteLine("Ingrese el primer numero:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2)
            {
                menor = n1;
                mayor = n2;
            }
            else
            {
                menor = n2;
                mayor = n1;
            }

            for (int i = menor; i <= mayor; i++)
            {
                suma = suma + i;
            }

            Console.WriteLine("La suma es: " + suma);
        }
    }
}