using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Jugador
    {
        public string nombre_jugador;

        public Jugador(int i)
        {
            Console.WriteLine("Inserte el nombre del {0}º jugador: ", i + 1);
            nombre_jugador = Console.ReadLine();
        }

    }
}
