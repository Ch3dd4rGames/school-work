using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("| " + i + "\t | " + (i * i) + "\t | " + (i * i * i) + "\t |");
            }
            Console.WriteLine("--------------------------");
        }
    }
}
