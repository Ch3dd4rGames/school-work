using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Coche c1 = new Coche(100);
            c1.Acelerar();

            Transporte t1 = new Transporte();
            t1.Acelerar();
            */

            Transporte[] transportes = new Transporte[3];
            transportes[0] = new Coche();
            transportes[0].Acelerar();
            transportes[1] = new Moto();
            transportes[1].Acelerar();
            transportes[2] = new Transporte();
            transportes[2].Acelerar();
        }
    }
}
