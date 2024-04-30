using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    internal abstract class Padre
    { //Una clase abstract está pensada para herencia, no se pueden instanciar en el mismo método
        protected int a;

        public Padre()
        {
            a = 0;
        }

        public Padre(int _a)
        {
            a = _a;
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        //virtual --> indica que este método se puede o bien ocultar o bien sobreescribir en la clase Hija
        public virtual int Restar(int a, int b)
        {
            return a - b;
        }

        //abstract --> solo se puede definir un método abastract en clases abstract
        //Un método abstract solo tiene cabecera, y no se puede definir el cuerpo de la función
        public abstract int Multiplicar(int a, int b);
    }
}
