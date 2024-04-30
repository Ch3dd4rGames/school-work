using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el primer número:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el tercer número:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                Console.WriteLine("Dos números o más son iguales.");
            }
            else if(n1 > n2 && n1 < n3 || n1 < n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " es el número del medio.");
            }
            else if (n2 > n1 && n2 < n3 || n2 < n1 && n2 > n3)
            {
                Console.WriteLine(n2 + " es el número del medio.");
            }
            else
            {
                Console.WriteLine(n3 + " es el número del medio.");
            }
        }
    }
}
