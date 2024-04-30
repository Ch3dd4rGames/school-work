using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess = new Random().Next(1, 11);
            int counter = 0;
            int max = 10;
            int min = 1;
            char answer;
            Console.WriteLine("Piensa en un número del 1 al 10. Voy a intentar adivinarlo.");
            Console.WriteLine("Presiona cualquier tecla cuando ya lo tengas pensado.");
            Console.ReadKey();
            Console.WriteLine("Perfecto. ¡Pues allá vamos!");

            do
            {
                Console.WriteLine("Es tu número " + guess + "? (S/N)");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out answer) || (answer != 'S' && answer != 'N'))
                {
                    Console.WriteLine("No te entiendo. ¿Podrías repetirlo?");
                }
                counter++;
                if (answer == 'N' && counter < 3)
                {
                    if (guess == min)
                    {
                        Console.WriteLine("Comprendo. Entonces tendrá que ser más GRANDE.");
                        min = min++;
                    }
                    else if (guess == max)
                    {
                        Console.WriteLine("Comprendo. Entonces tendrá que ser más PEQUEÑO.");
                        max = max--;
                    }
                    else
                    {
                        Console.WriteLine("Vaya. ¿Es más GRANDE o más PEQUEÑO? (G/P)");
                        while (!char.TryParse(Console.ReadLine().ToUpper(), out answer) || (answer != 'G' && answer != 'P'))
                        {
                            Console.WriteLine("No te entiendo. ¿Podrías repetirlo?");
                        }
                    }
                    if (answer == 'G' || guess == 1)
                    {
                        Random rand = new Random();
                        guess = rand.Next(guess++, 11);
                    }
                    else if (answer == 'P' || guess == 10)
                    {
                        Random rand = new Random();
                        guess = rand.Next(1, guess);
                    }
                }
                else
                {
                    Console.Write("");
                }
            } while (answer != 'S' && counter < 3);

            if (answer == 'S')
            {
                Console.WriteLine("¡Sí! He ganado.");
            }
            else
            {
                Console.WriteLine("¡No! Me he quedado sin intentos. Te ganaré la proxima vez.");
            }
        }
    }
}
