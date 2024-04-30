using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    num = rand.Next(1, 101);
                    if (num <= 25)
                    {
                        Console.Write(" 1 ");
                    }
                    else
                    {
                        Console.Write(" 0 ");
                    }
                }

                Console.WriteLine("");
            }
        }
    }
}
