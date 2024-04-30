using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta tu NOTA:");
            double n = Convert.ToDouble(Console.ReadLine());

            if (n < 0 || n > 10)
            {
                Console.WriteLine("No has metido una nota correcta.");
            }
            else if (n >= 9)
            {
                Console.WriteLine("Has sacado SOBRESALIENTE.");
            }
            else if (n >= 7)
            {
                Console.WriteLine("Has sacado NOTABLE.");
            }
            else if (n >= 5)
            {
                Console.WriteLine("Has sacado APROBADO.");
            }
            else
            {
                Console.WriteLine("Has sacado SUSPENSO.");
            }
        }
    }
}
