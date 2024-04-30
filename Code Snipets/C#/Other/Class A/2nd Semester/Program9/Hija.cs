using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    internal class Hija : Padre
    {
        private int b;

        public Hija()
        {
            b = 0;
        }

        public Hija(int b) : base(6)
        {
            this.b = b;
        }

        public Hija(int a, int _b) : base(a)
        {
            this.Sumar(2, 3);
            b = _b;
        }

        //new --> oculta el método de la clase Padre
        public new int Sumar(int a, int b)
        {
            if (a + b > 0)
                return base.Sumar(a, b);
            else
                return this.Sumar(base.a, b, this.b);
        }

        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

        //override --> sobreescribe el método de la clase Padre
        public override int Restar(int a, int b)
        {
            if (a - b > 0)
                return a - b;
            else
                return 0;
        }

        public override int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}
