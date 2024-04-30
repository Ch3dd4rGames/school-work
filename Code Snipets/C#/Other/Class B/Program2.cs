using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroPensado = 0;
            double decimalAleatorio = 0;
            while (true)
            {
                numeroPensado = random.Next(1, 11);
                decimalAleatorio = random.NextDouble() * 7;
                Console.WriteLine(numeroPensado + "     " + decimalAleatorio);
                Console.ReadLine();
            }
        }
    }
}
