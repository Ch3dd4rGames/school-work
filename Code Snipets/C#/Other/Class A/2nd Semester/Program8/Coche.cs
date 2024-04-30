using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Coche : Transporte
    {
        const int VelocidadMaxima = 200;

        public Coche()
        {
            MaxNumPasajeros = 4;
            //Console.WriteLine("CONSTRUCTOR DE Coche");
        }

        public Coche(int v) : base(v)
        {
            //Console.WriteLine("CONSTRUCTOR DE Coche");
        }

        public Coche(int v, int c) : base(v, c)
        {
            //Console.WriteLine("CONSTRUCTOR DE Coche");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerar de COCHE");
            Velocidad++;

            if (Velocidad > VelocidadMaxima)
                Velocidad = VelocidadMaxima;
        }
    }
}
