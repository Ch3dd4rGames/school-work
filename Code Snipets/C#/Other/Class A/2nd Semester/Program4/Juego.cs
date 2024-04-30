using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3enRayaPOO
{
    internal class Juego
    {
        int turno, contador_jugadas;
        Tablero tablero;
        Jugador [] jugadores = new Jugador[2];
        bool ModoTesteo = true;
        
        public Juego() 
        {
            int victoria;
            tablero = new Tablero();
            jugadores[0] = new Jugador('X',false);
            jugadores[1] = new Jugador('O', false);
            turno = 0;
            contador_jugadas = 0;
            Thread.Sleep(1000); //Pausa de 1 segundo
            
            do
            {
                Console.Clear();
                CambiarTurno();
                jugadores[turno].RealizarJugada(tablero);
                tablero.MostrarPantalla();

                if (!ModoTesteo)
                {
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey();
                }

                contador_jugadas++;
                victoria = tablero.ComprobarVictoria(jugadores[turno].Ficha);
            } while (victoria == 0 && contador_jugadas < tablero.Length);

            if (victoria == 0)
                Console.WriteLine("\nEMPATE");
            else
               Console.WriteLine("\n{0} - Ha ganado el jugador {1} ", victoria, jugadores[turno].Ficha);
        }

        private void CambiarTurno() 
        {
            if (turno == 0)
                turno = 1;
            else
                turno = 0;
        }
    }
}
