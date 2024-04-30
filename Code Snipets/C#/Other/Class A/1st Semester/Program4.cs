using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main (string[] args)
        {
            long n;
            Console.WriteLine("Escribe un número ENTERO:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " es un número PAR.");
            }
            else
            {
                Console.WriteLine(n + " es un número IMPAR.");
            }
        }
    }
}
