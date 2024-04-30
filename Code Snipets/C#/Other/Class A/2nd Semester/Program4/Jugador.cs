using System;
using System.Collections.Generic;
using System.Text;

namespace _3enRayaPOO
{
    internal class Jugador
    {
        public readonly char Ficha;
        bool Humano;

        public Jugador(char f, bool humano = false) 
        {
            Ficha = f;
            Humano = humano;    
            Console.WriteLine("Jugador creado - " + Ficha);
        }

        public void RealizarJugada(Tablero t)
        {
            if (Humano)
                RealizarJugadaHumano(t);
            else
                RealizarJugadaIA(t);
        }

        private void RealizarJugadaIA(Tablero t) 
        {
            int f, c;
            Random r = new Random();
            bool jugada_correcta;
            
            do
            {
                f = r.Next(0, t.Filas);
                c = r.Next(0, t.Columnas);
                jugada_correcta = t.InsertarFicha(Ficha, f, c);
            } while (!jugada_correcta);
        }

        private void RealizarJugadaHumano(Tablero t)
        { 
            int f, c;
            bool jugada_correcta;
            Console.WriteLine("Turno de " + Ficha);

            do 
            { 
                Console.Write("Escoge una fila: ");
                while (!int.TryParse(Console.ReadLine(), out f) || f < 0 || f >= t.Filas)
                {
                    Console.Write("Error, debes insertar un número entre {0} y {1}. Escoge una fila: ", 0, t.Filas - 1);
                }

                Console.Write("Escoge una columna: ");
                while (!int.TryParse(Console.ReadLine(), out c) || c < 0 || c >= t.Columnas)
                {
                    Console.Write("Error, debes insertar un número entre {0} y {1}. Escoge una columna: ", 0, t.Columnas - 1);
                }

                jugada_correcta = t.InsertarFicha(Ficha, f, c);
                if (!jugada_correcta)
                    Console.WriteLine("Error, la casilla escogida está ocupada. Inténtalo de nuevo");
            } while(!jugada_correcta);
        }
    }
}
