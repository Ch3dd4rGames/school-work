using System;
using System.Threading;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador = contador + 2;
            }
        }
    }
}
