using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta un número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 1;
            int divisibles = 0;
            do
            {
                if (numero % contador == 0)
                {
                    divisibles++;
                }
                contador++;
            } while (contador <= numero);

            if (divisibles <= 2)
            {
                Console.WriteLine(numero + " es un número PRIMO.");
            }
            else
            {
                Console.WriteLine(numero + " NO es un número primo.");
            }
        }
    }
}
