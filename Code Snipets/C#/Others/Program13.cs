using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] dentro = new int[10];
            int[] fuera = new int[10];
            int n1, n2;
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = new Random().Next(1, 101);
            }

            Console.WriteLine("Inserte un primer número del 1 al 100:");
            while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 1 || n1 > 100)
            {
                Console.WriteLine("El valor insertado no es válido.");
                Console.WriteLine("Inserte un número del 1 al 100:");
            }
            Console.WriteLine("Inserte un segundo número del 1 al 100:");
            while (!int.TryParse(Console.ReadLine(), out n2) || n2 < 1 || n2 > 100)
            {
                Console.WriteLine("El valor insertado no es válido.");
                Console.WriteLine("Inserte un número del 1 al 100:");
            }

            if (n1 > n2)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] <= n1 && numeros[i] >= n2)
                    {
                        dentro[i] = numeros[i];
                    }
                    else
                    {
                        fuera[i] = numeros[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] >= n1 && numeros[i] <= n2)
                    {
                        dentro[i] = numeros[i];
                    }
                    else
                    {
                        fuera[i] = numeros[i];
                    }
                }
            }

            Console.Write("SÍ estan dentro del rango:");
            for (int i = 0; i < 10; i++)
            {
                if (dentro[i] != 0)
                {
                    Console.Write(" " + dentro[i] + " ");
                }
            }
            Console.WriteLine("");
            Console.Write("NO estan dentro del rango:");
            for (int i = 0; i < 10; i++)
            {
                if (fuera[i] != 0)
                {
                    Console.Write(" " + fuera[i] + " ");
                }
            }

        }
    }
}
