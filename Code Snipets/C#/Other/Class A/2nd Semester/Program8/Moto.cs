using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Moto : Transporte
    {
        public Moto()
        {
            MaxNumPasajeros = 2;
        }

        public new void Acelerar()
        {
            Console.WriteLine("Acelerar de MOTO");
            Velocidad += 2;
        }
    }
}
