using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(1, 11);
            int guess = 0;
            int counter = 0;
            Console.WriteLine("He pensado en un número del 1 al 10. Intenta adivinarlo.");
            do
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < num)
                {
                    Console.WriteLine("Mi número es más GRANDE.");
                }
                else if (guess > num)
                {
                    Console.WriteLine("Mi número es más PEQUEÑO.");
                }
                else
                {
                    Console.Write("");
                }
                counter++;
            } while (guess != num && counter < 3);

            if (guess == num)
            {
                Console.WriteLine("¡FELICIDADES! Adivinaste mi número");
            }
            else
            {
                Console.WriteLine("¡Qué pena! Te has quedado sin intentos. La respuesta era " + num + ".");
            }
        }
    }
}
