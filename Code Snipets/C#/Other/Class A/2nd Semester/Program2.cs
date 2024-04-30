using System;//
using System.Threading;


namespace ConsoleApp2
{
    internal class Program
    {
        static void RealizarJugadaIA(char[,] tablero, char ficha)
        {

            int f, c;
            Random r = new Random();
            bool jugada_realizada = false;
            do
            {
                f = r.Next(0, tablero.GetLength(0));
                c = r.Next(0, tablero.GetLength(1));
                if (tablero[f, c] == '_')//esa posición está libre
                {
                    tablero[f, c] = ficha;
                    jugada_realizada = true;
                }
            } while (!jugada_realizada);

        }


        static void InicializarTableroTicTacToe(out char[,] matriz, int filas, int columnas)
        {
            int i, j;
            Random dado = new Random();

            matriz = new char[filas, columnas];
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = '_';
                }
            }

        }


        static void InicializarMatrizAleatoria(out char[,] matriz, int filas, int columnas)
        {
            int i, j;
            Random dado = new Random();

            matriz = new char[filas, columnas];
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {//se genera aleatoriamente una X o una O en cada posición
                    if (dado.Next(0, 2) == 0)
                        matriz[i, j] = 'O';
                    else
                        matriz[i, j] = 'X';
                }
            }

        }

        static bool ComprobarHorizontal(char[,] tablero, int n, char ficha)
        {
            //esta función dice si hay un num_elementos_en_raya iguales en horizontal
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por tanto, la que vamos a comparar
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

                    if (contador == n)
                        victoria = true;
                }
            }

            return victoria;
        }



        static bool ComprobarVertical(char[,] tablero, int n, char ficha)
        {
            //esta función dice si hay un num_elementos_en_raya iguales en vertical
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por tanto, la que vamos a comparar
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

                    if (contador == n)
                        victoria = true;
                }
            }

            return victoria;
        }

        static bool ComprobarDiagonal(char[,] tablero, int n, char ficha)
        {
            //esta función dice si hay un num_elementos_en_raya iguales en diagonal /
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por tanto, la que vamos a comparar
            bool victoria = false;
            int contador;

            for (int i = 0; i <= tablero.GetLength(0) - n && !victoria; i++) //Recorrer las filas
            {
                for (int j = 0; j <= tablero.GetLength(1) - n && !victoria; j++) //Recorrer las columnas
                {
                    contador = 0;
                    //Aquí ya estamos posicionados en una casilla [i, j]
                    for (int k = 0; k < n && !victoria; k++) //Recorrer la diagonal de esa casilla
                    {
                        if (tablero[i + k, j + k] == ficha)
                            contador++;
                        else
                        {
                            contador = 0;
                            k = n; //Esto sirve para forzar la salida del bucle, porque ya no va a ser posible encontrar n en raya
                        }

                        if (contador == n)
                            victoria = true;
                    }
                }
            }

            return victoria;
        }

        static bool ComprobarDiagonal2(char[,] tablero, int n, char ficha)
        {
            //esta función dice si hay un num_elementos_en_raya iguales en diagonal \
            //n es el nº de elementos que tiene que haber en línea para que haya victoria
            //ficha contiene la última ficha que se colocó, y por tanto, la que vamos a comparar
            bool victoria = false;
            int contador;

            for (int i = 0; i <= tablero.GetLength(0) - n && !victoria; i++) //Recorrer las filas
            {
                for (int j = n - 1; j < tablero.GetLength(1) && !victoria; j++) //Recorrer las columnas
                {
                    contador = 0;
                    //Aquí ya estamos posicionados en una casilla [i, j]
                    for (int k = 0; k < n && !victoria; k++) //Recorrer la diagonal de esa casilla
                    {
                        if (tablero[i + k, j - k] == ficha)
                            contador++;
                        else
                        {
                            contador = 0;
                            k = n; //Esto sirve para forzar la salida del bucle, porque ya no va a ser posible encontrar n en raya
                        }

                        if (contador == n)
                            victoria = true;
                    }
                }
            }

            return victoria;
        }


        static bool ComprobarVictoria(char[,] tablero, int n, char ficha)
        {
            if (ComprobarHorizontal(tablero, n, ficha))
                return true;
            else if (ComprobarVertical(tablero, n, ficha))
                return true;
            else if (ComprobarDiagonal(tablero, n, ficha))
                return true;
            else if (ComprobarDiagonal2(tablero, n, ficha))
                return true;
            else
                return false;
        }

        static void MostrarPantallaTablero(char[,] tablero)
        {

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("{0,4}", tablero[i, j]);
                }
                Console.WriteLine("\n");//salto de línea

            }
        }

        static void CambiarTurno(ref char ficha)
        {
            if (ficha == 'X')
                ficha = 'O';
            else
                ficha = 'X';
        }


        static void Main(string[] args)
        {
            const int FILAS = 3;
            const int COLUMNAS = 3;
            const int N = 3; //nº de elementos en línea que tiene que haber para que haya victoria
            char[,] tablero;
            bool victoria = false;
            int contador_jugadas = 0;
            char ficha = 'X';

            InicializarTableroTicTacToe(out tablero, FILAS, COLUMNAS);
            MostrarPantallaTablero(tablero);

            do
            {
                //Thread.Sleep(1000);//pausa de 1 segundo
                Console.Clear();
                CambiarTurno(ref ficha);
                RealizarJugadaIA(tablero, ficha);
                MostrarPantallaTablero(tablero);
                contador_jugadas++;
                victoria = ComprobarVictoria(tablero, N, ficha);


            } while (!victoria && contador_jugadas < tablero.Length);
            if (victoria == true)
            {
                Console.WriteLine("Hay un ganador");
            }
            else
            {
                Console.WriteLine("No hay ganador");
            }
        }
    }
}
