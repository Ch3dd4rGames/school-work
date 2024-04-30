using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Transporte
    {
        protected int MaxNumPasajeros;
        protected int Velocidad;
        private double CapacidadCarga;
        private int NumPasajeros;

        public Transporte()
        {
            Velocidad = 0;
            CapacidadCarga = 400;
            //Console.WriteLine("CONSTRUCTOR DE Transporte");
        }

        public Transporte(int v)
        {
            Velocidad = v;
            CapacidadCarga = 400;
            //Console.WriteLine("CONSTRUCTOR DE Transporte");
        }

        public Transporte(int v, int c)
        {
            Velocidad = v;
            CapacidadCarga =c;
            //Console.WriteLine("CONSTRUCTOR DE Transporte");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerar de TRANSPORTE");
            Velocidad++;
        }

        public virtual void Frenar()
        {
            Velocidad--;
            if (Velocidad < 0)
                Velocidad = 0;
        }
    }
}
