using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte el primer lado del triángulo:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserte el segundo lado del triángulo:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserte el tercer lado del triángulo:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 == n2 && n1 == n3)
            {
                Console.WriteLine("Se trata de un triángulo EQUILÁTERO.");
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                Console.WriteLine("Se trata de un triángulo ISÓSCELES.");
            }
            else
            {
                Console.WriteLine("Se trata de un triángulo ESCALENO.");
            }
        }
    }
}
