using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Circulo
    {
        public const double PI = 3.1416;
        readonly double radio;

        public Circulo(int r)
        {
            if (r > 0)
                radio = r;
            else
                radio = 0;
        }

        public double CalcularCircunferencia()
        {
            return 2 * PI * radio;
        }
    }
}
