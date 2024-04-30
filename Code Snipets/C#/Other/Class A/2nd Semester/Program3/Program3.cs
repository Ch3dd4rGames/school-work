using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static int Abs(int a)
        {
            if (a < 0)
                return a * (-1);
            else
                return a;
        }

        static double Abs(double a)
        {
            if (a < 0)
                return a * (-1);
            else
                return a;
        }

        static long Abs(long a)
        {
            if (a < 0)
                return a * (-1);
            else
                return a;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            long c = long.MaxValue;
            Abs(c);

            Coche coche1 = new Coche();
            Coche coche2 = new Coche(300, 200, 100, 200, "verde", "Tesla");
            Coche coche3 = new Coche(250, 120);

            coche1.Acelerar(5);
            coche1.Frenar(5);
            coche3.Acelerar(25);
        }
    }
}
