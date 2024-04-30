using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hija h = new Hija();
            h.Sumar(2, 3);

            /*
            Padre p = new Padre();
            p.Sumar(2, 3);
            */

            Padre generico = new Hija();
            generico.Sumar(2, 3); //Llama al método oculto de la clase Padre
            generico.Restar(2, 3); //Llama al método sobreescrito de la clase Hija
        }
    }
}
