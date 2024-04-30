using System;

namespace ConsoleApp
{
    class Program
    {
        static void InicializarMatriz(out int[,] matriz, int filas, int columnas)
        {
            int i, j;
            Random dado = new Random();

            matriz = new int[filas, columnas];
            for (i = 0; i < matriz.GetLength(0); i++)
                for (j = 0; j < matriz.GetLength(1); j++)
                    matriz[i, j] = dado.Next(0, filas * columnas);
        }

        static void InicializarMatrizNoRepetidos(out int[,] matriz, int filas, int columnas)
        {
            int i, j;
            Random dado = new Random();
            matriz = new int[filas, columnas];
            for (i = 0; i < matriz.GetLength(0); i++)
                for (j = 0; j < matriz.GetLength(1); j++)
                    do
                        matriz[i, j] = dado.Next(0, filas * columnas);
                    while (DatoRepetido(matriz, i, j));

        }

        static void MostrarPantallaMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)//Recorre las filas
            {
                for (int j = 0; j < matriz.GetLength(1); j++)//Recorre las columnas por cada fila
                    //Console.WriteLine("En la posición [{0},{1}] está el valor {2}", i, j, matriz[i, j]);
                    //Console.Write("El valor de la matriz es en la posición [{2},{1}] es {0} ", matriz[i, j], j, i);
                    //Console.Write("El valor de la matriz es en la posición [" + i + "," + j + "] es " + matriz[i, j] + " ");
                    //Console.Write(matriz[i, j] + " ");//Equivalente a la anterior
                    Console.Write("{0, 4}", matriz[i, j]);
                Console.WriteLine("\n");//Salto de línea
            }
        }

        static bool DatoRepetido(int[,] matriz, int fila, int columna)
        {   //Fila y columna son la posición del dato que se ha insertado, y que se quiere saber si está repetido
            //Comprobación de si los datos recibidos son correctos           
            if (matriz.GetLength(0) <= fila || fila < 0 || matriz.GetLength(1) <= columna || columna < 0)
                //Console.WriteLine("Las posiciones de fila y/o columna son incorrectas, no se pudo completar la operación");
                return false;

            int i, j;
            bool encontrado = false;
            if (columna == 0)
                i = fila - 1;
            else
                i = fila;

            //Console.WriteLine("Comprobando el dato [{0},{1}]- valor {2}", fila, columna, matriz[fila, columna]);
            for (; i >= 0 && !encontrado; --i)
            {
                if (i == fila && columna != 0)
                    j = columna - 1;
                else
                    j = matriz.GetLength(1) - 1;

                for (; j >= 0 && !encontrado; --j)
                    //Console.WriteLine("\tBuscando el dato [{0},{1}]- valor {2}", i, j, matriz[i, j]);
                    if (matriz[i, j] == matriz[fila, columna])
                        encontrado = true;
            }
            //Console.WriteLine("\tEncontrado " + encontrado + "\n");
            return encontrado;
        }

        static bool BuscarDatoEnMatriz(int[,] matriz, int n)
        {
            bool encontrado = false;

            for (int i = 0; i < matriz.GetLength(0) && !encontrado; i++)
                for (int j = 0; j < matriz.GetLength(1) && !encontrado; j++)
                    if (matriz[i, j] == n)
                        encontrado = true;

            return encontrado;

        }

        static void Main(string[] args)
        {
            int FILAS;
            int COLUMNAS;
            int[,] matriz;
            int n;
            bool encontrado;
            Console.WriteLine("Inserta el número de FILAS (1, 30): ");
            while (!int.TryParse(Console.ReadLine(), out FILAS) || FILAS > 30 || FILAS < 1)
                Console.Write("Error, debes insertar un número entero del 1 al 30. Inténtalo de nuevo: ");
            Console.WriteLine("Inserta el número de COLUMNAS (1, 30): ");

            while (!int.TryParse(Console.ReadLine(), out COLUMNAS) || COLUMNAS > 30 || COLUMNAS < 1)
                Console.Write("Error, debes insertar un número entero del 1 al 30. Inténtalo de nuevo: ");

            //Console.WriteLine("Comienza el programa");
            InicializarMatrizNoRepetidos(out matriz, FILAS, COLUMNAS);
            MostrarPantallaMatriz(matriz);

            Console.WriteLine("Inserta un número: ");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.Write("Error, debes insertar un número entero. Inténtalo de nuevo: ");

            if (BuscarDatoEnMatriz(matriz, n))
                Console.WriteLine("{0} sí está en la matriz", n);
            else
                Console.WriteLine("{0} no está en la matriz", n); 
            
            encontrado = BuscarDatoEnMatriz(matriz, n);


        }
    }
}
