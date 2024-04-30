using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta un número:");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 3;
            do
            {
                Console.WriteLine(c);
                c = c + 3;
            } while (c <= n);
        }
    }
}
