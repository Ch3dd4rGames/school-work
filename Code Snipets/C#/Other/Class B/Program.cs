using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte el primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserte el segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escoja una de las siguientes operaciones: ");
            Console.WriteLine("1.- Mayor y menor.");
            Console.WriteLine("2.- Distancia. ");
            Console.WriteLine("3.- Media.");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    if (n1 > n2)
                    {
                        Console.WriteLine(n1 + " es el número mayor y " + n2 + " el menor.");
                    }
                    else if (n1 < n2)
                    {
                        Console.WriteLine(n2 + " es el número mayor y " + n1 + " el menor.");
                    }
                    else
                    {
                        Console.WriteLine("Ambos números son iguales.");
                    }
                    break;
            
                case 2:
                    if (n1 >= n2)
                    {
                        Console.WriteLine("La distancia entre ambos números es de " + (n1 - n2) + ".");
                    }
                    else
                    {
                        Console.WriteLine("La distancia entre ambos números es de " + (n2 - n1) + ".");
                    }
                    break;

                case 3:
                    Console.WriteLine("La media entre ambos números es de " + ((n1 + n2) / 2) + ".");
                    break;

                default:
                    Console.WriteLine("No has metido una operación correcta.");
                    break;
            }
        }
    }
}


