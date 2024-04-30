using System;
using System.Collections.Generic;
using System.Text;

namespace _3enRayaPOO
{
    internal class Tablero
    {
        private char[,] tablero;
        public readonly int Filas, Columnas, Length;
        private readonly int N; //Nº de elementos que tiene que haber en línea para que haya victoria

        public Tablero(int n = 3, int filas = 3, int columnas = 3) 
        {
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            N = n;
            Filas = filas;
            Columnas = columnas;
            Length = Filas * Columnas;
            InicializarTablero();
        }

        public bool InsertarFicha(char ficha, int fila, int columna) 
        {
            bool jugada_correcta;
            if (fila < 0 || columna < 0 || fila >= Filas || columna >= Columnas)
                jugada_correcta = false;
            else if (tablero[fila, columna] != '_')
                jugada_correcta = false;
            else 
            {
                tablero[fila, columna] = ficha;
                jugada_correcta = true;
            }
            return jugada_correcta;
        }

        private void InicializarTablero()
        {
            int i, j;           
            tablero = new char[Filas, Columnas];
            for (i = 0; i < tablero.GetLength(0); i++)
            {
                for (j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = '_';
                }
            }
        }

        public void MostrarPantalla() {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("{0,4}", tablero[i, j]);
                }
                Console.WriteLine("\n"); //Salto de línea
            }
        }

        bool ComprobarHorizontal(char ficha)
        {
            //Esta función dice si hay un número de elementos en raya iguales en horizontal
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por lo tanto, la que vamos a comparar
            bool victoria = false;
            int contador;

            for (int i = 0; i < tablero.GetLength(0) && !victoria; i++)
            {
                contador = 0;
                for (int j = 0; j < tablero.GetLength(1) && !victoria; j++)
                {
                    if (tablero[i, j] == ficha)
                        contador++;
                    else
                        contador = 0;

                    if (contador == N)
                        victoria = true;
                }
            }
            return victoria;
        }

        bool ComprobarVertical(char ficha)
        {
            //Esta función dice si hay un número de elementos en raya iguales en vertical
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por lo tanto, la que vamos a comparar
            bool victoria = false;
            int contador;

            for (int j = 0; j < tablero.GetLength(1) && !victoria; j++)
            {
                contador = 0;
                for (int i = 0; i < tablero.GetLength(0) && !victoria; i++)
                {
                    if (tablero[i, j] == ficha)
                        contador++;
                    else
                        contador = 0;

                    if (contador == N)
                        victoria = true;
                }
            }
            return victoria;
        }

        bool ComprobarDiagonalA(char ficha)
        {
            //Esta función dice si hay un número de elementos en raya iguales en diagonal \
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por lo tanto, la que vamos a comparar
            bool victoria = false;
            int contador;

            for (int i = 0; i <= tablero.GetLength(0) - N && !victoria; i++) //Recorre las filas
            {
                for (int j = 0; j <= tablero.GetLength(1) - N && !victoria; j++) //Recorre las columnas
                {
                    contador = 0;
                    //for (int k = 0; i + k < tablero.GetLength(0) && j + k < tablero.GetLength(1) && !victoria; k++) //Por cada casilla, recorre su diagonal \
                    for (int k = 0; k < N && !victoria; k++) //Por cada casilla, recorre su diagonal \
                    {
                        if (tablero[i + k, j + k] == ficha)
                        {
                            contador++;
                        }                          
                        else
                        {
                            contador = 0; //No va a ser posible encontrar todos los elementos
                            //k = tablero.GetLength(0); //Este valor fuerza la salida del bucle, e indica que pase al siguiente elemento
                            k = N; //Forzamos la salida del bucle
                        }

                        if (contador == N)
                            victoria = true;
                    }
                }
            }
            return victoria;
        }

        bool ComprobarDiagonalB(char ficha)
        {
            //Esta función dice si hay un número de elementos en raya iguales en diagonal /
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por lo tanto, la que vamos a comparar
            bool victoria = false;
            int contador;

            for (int i = 0; i <= tablero.GetLength(0) - N && !victoria; i++) //Recorre las filas
            {
                for (int j = N - 1; j < tablero.GetLength(1) && !victoria; j++) //Recorre las columnas
                {
                    contador = 0;
                    for (int k = 0; k < N && !victoria; k++) //Por cada casilla, recorre su diagonal /
                    {
                        if (tablero[i + k, j - k] == ficha)
                        {
                            contador++;
                        }
                        else
                        {
                            contador = 0; //No va a ser posible encontrar todos los elementos
                            k = N; //Este valor fuerza la salida del bucle, e indica que pase al siguiente elemento
                        }

                        if (contador == N)
                            victoria = true;
                    }
                }
            }
            return victoria;
        }

        public int ComprobarVictoria(char ficha)
        {
            if (ComprobarHorizontal(ficha))
                return 1;
            else if (ComprobarVertical(ficha))
                return 2;
            else if (ComprobarDiagonalA(ficha))
                return 3;
            else if (ComprobarDiagonalB(ficha))
                return 4;
            else
                return 0;
        }
    }
}
