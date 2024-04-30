using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class JuegoAhorcado
    {
        private Jugador[] jugadores;
        private PalabraOculta palabra;
        int numFallos = 0, turnos = 0, intentos = 0, yaAcertados = 0;
        char adivinanza;
        char[] yaIntentados = new char[25];
        bool gameOver = false, yaUsado;

        public JuegoAhorcado()
        {
            jugadores = new Jugador[3];
            for (int i = 0; i < jugadores.Length; i++)
            {
                jugadores[i] = new Jugador(i);
            }
            string p = ColeccionPalabras.PalabraAleatoria();
            palabra = new PalabraOculta(p);

            while (numFallos < Figura.MAX_FALLOS && !gameOver)
            {
                yaUsado = false;
                Console.Clear();
                Console.WriteLine("TURNO DE {0}: ", jugadores[turnos].nombre_jugador);
                Figura.PintarFigura(numFallos);
                Console.Write("\nLetras ya usadas: ");
                for (int i = 0; i < yaIntentados.Length; i++)
                {
                    Console.Write(yaIntentados[i] + " ");
                }
                Console.WriteLine("\nEscoge una letra: ");
                do
                {
                    while (!char.TryParse(Console.ReadLine(), out adivinanza))
                    {
                        Console.WriteLine("Inserta una letra.");
                    }
                    adivinanza = char.ToLower(adivinanza);
                    Console.WriteLine("\n");
                    for (int i = 0; i < yaIntentados.Length; i++)
                    {
                        if (adivinanza == yaIntentados[i])
                            yaUsado = true;
                        else
                            yaUsado = false;
                    }
                    if (yaUsado)
                        Console.WriteLine("Ya has intentado esa letra.");
                }while (yaUsado);
                    yaIntentados[intentos] = adivinanza;
                    palabra.MostrarResultados(adivinanza, p);

                    if (palabra.numAciertos == p.Length)
                        gameOver = true;
                    else
                        Console.ReadKey();
                    if (palabra.numAciertos <= yaAcertados)
                    {
                        numFallos++;
                    }
                    yaAcertados = palabra.numAciertos;
                    palabra.numAciertos = 0;
                    intentos++;
                    turnos++;
                    if (turnos == jugadores.Length)
                        turnos = 0;
            }

            if (gameOver)
                Console.WriteLine("¡FELICIDADES! Lo has adivinado. ");
            else
            {
                Console.Clear();
                Figura.PintarFigura(numFallos);
                Console.WriteLine("La respuesta era {0}.", p);
            }
        }
    }
}

