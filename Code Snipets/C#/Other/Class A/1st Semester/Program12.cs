using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora;
            int media = 0;
            int[] temperaturas = new int[24];
            char decision;
            for (hora = 0; hora < 24; hora++)
            {
                Console.WriteLine("Dígame qué temperatura hizo a la(s) " + hora + ":00.");
                while (!int.TryParse(Console.ReadLine(), out temperaturas[hora]))
                {
                    Console.WriteLine("El valor insertado no es un número.");
                    Console.WriteLine("Inserte una temperatura válida:");
                }
                media = media + temperaturas[hora];
            }

            media = media / 24;
            Console.WriteLine("");
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("Inserte la hora que quiera consultar:");
                while (!int.TryParse(Console.ReadLine(), out hora) || hora < 0 || hora > 23)
                {
                    Console.WriteLine("El valor insertado no es una hora real.");
                    Console.WriteLine("Inserte una hora válida:");
                }

                Console.WriteLine("A la(s) " + hora + ":00 hizo " + temperaturas[hora] + "ºC.");
                if (temperaturas[hora] < media)
                {
                    Console.WriteLine("Esa temperatura es MENOR a la media, que se trata de " + media + "ºC.");
                }
                else if (temperaturas[hora] > media)
                {
                    Console.WriteLine("Esa temperatura es MAYOR a la media, que se trata de " + media + "ºC.");
                }
                else
                {
                    Console.WriteLine("Esa temperatura es IGUAL a la media.");
                }

                Console.WriteLine("¿Desea consultar alguna otra hora? (S/N)");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out decision) || (decision != 'S' && decision != 'N'))
                {
                    Console.WriteLine("El valor insertado no es una respuesta válida.");
                    Console.WriteLine("Responda con S o N");
                }
            } while (decision != 'N');
        }
    }
}