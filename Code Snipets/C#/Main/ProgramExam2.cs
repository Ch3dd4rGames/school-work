using System;

namespace Juego_de_los_Pastores_EDER
//Creado por Eder Cajigas Encina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero_filas; Dimensiones del tablero
            //int numero_piedras; Número de piedras inicial del tablero
            //int[] tablero; Para plasmar las dimensiones en pantalla
            //int filas, piedras; Para solicitar al usuario la jugada
            //int eleccion; Para tomar decisiones en el menú
            //int turnos; para contar los turnos pasados
            string[] nombres = new string[10]; //Para guardar los nombres de los jugadores en el High Score
            int[] victorias = new int[10]; //Para guardar las victorias de los jugadores en el High Score
            int[] derrotas = new int[10]; //Para guardar las derrotas de los jugadores en el High Score
            //string jugador, j1, j2; Nombre general y nombres iniciales de los jugadores
            //bool PvP; Para definir si la partida será contra otro jugador o contra un bot
            //bool fin_partida; Para definir si la partida continúa o termina

            //Llamar al High Score inicial para asignarle sus valores predeterminados
            StartingHighscore(nombres, victorias, derrotas);

            //Llamar al menú principal por primera vez, con los valores iniciales
            MenúPrincipal(4, 6, new int[4], 0, 0, 1, 0, nombres, victorias, derrotas, "", "Jugador 1", "Jugador 2", true, true);
        }

        //Función de asignación de valores de los 3 arrays del High Score
        static void StartingHighscore(string[] nombres, int[] victorias, int[] derrotas)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = "";
                victorias[i] = 0;
                derrotas[i] = 0;
            }
        }

        //Interfaz principal del programa
        static void MenúPrincipal(int numero_filas, int numero_piedras, int[] tablero, int filas, int piedras, int turnos, int eleccion, string[] nombres, int[] victorias, int[] derrotas, string jugador, string j1, string j2, bool PvP, bool fin_partida)
        {
            do
            {
                Console.WriteLine("1. Mostrar reglas.");
                Console.WriteLine("2. Personalizar.");
                Console.WriteLine("3. Modo de juego.");
                Console.WriteLine("4. Jugar.");
                Console.WriteLine("5. High Scores.");
                Console.WriteLine("6. Salir.");
                //Se evita que se responda con ninguna respuesta indeseada
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 6)
                {
                    Console.WriteLine("Inserte una opción válida.");
                }
                //El programa toma un camino dependiendo del número escogido
                switch (eleccion)
                {
                    case 1:
                        Console.Clear(); //Limpiar la pantalla

                        //Imprime en pantalla las instrucciones del juego
                        Console.WriteLine("Dos jugadores se encuentran con una especie de tablero, compuesto por una serie de piedras colocadas en filas. Al iniciar la partida, cada una de las filas contiene igual número de piedras(por defecto, 4 filas de 6 piedras cada una, aunque opcionalmente, estos valores pueden ser escogidos por el usuario antes de comenzar la partida).");
                        Console.WriteLine("Alternativamente por turnos, los jugadores irán quitando piedras del tablero, teniendo que quitar como mínimo una piedra y como máximo todas las piedras de una fila. Un jugador no podrá quitar piedras de distintas filas en un mismo turno. Tampoco se pueden quitar piedras en vertical o en diagonal.");
                        Console.WriteLine("Ganará el jugador que obligue al oponente a retirar la última piedra, es decir, el jugador que deje el tablero con una sola piedra. Dicho de otra manera, pierde el jugador que deja el tablero sin piedras.");
                        Console.WriteLine(); //Salto de línea
                        break;
                    case 2:
                        Console.Clear(); //Limpiar la pantalla

                        //Llamar al menú de personalización, para ajustar dimensiones y nombres
                        Personalizar(ref numero_filas, ref numero_piedras, ref tablero, ref eleccion, ref j1, ref j2, PvP);
                        break;
                    case 3:
                        Console.Clear(); //Limpiar la pantalla

                        //Llamar al menú de modo, para escoger entre otro jugador o una IA como tu oponente
                        ModoDeJuego(ref eleccion, ref PvP);
                        break;
                    case 4:
                        Console.Clear(); //Limpiar la pantalla
                        fin_partida = false; //Marca que la partida ha comenzado

                        //Llamar al modo principal, con el que se puede jugar al juego de los pastores
                        Jugar(numero_piedras, tablero, filas, piedras, turnos, ref eleccion, nombres, victorias, derrotas, jugador, j1, j2, PvP, ref fin_partida);
                        break;
                    default:
                        Console.Clear(); //Limpiar la pantalla

                        //Imprime en pantalla el High Score actual
                        for (int i = 0; i < nombres.Length; i++)
                        {
                            Console.WriteLine("Nombre: " + nombres[i] + ".");
                            Console.WriteLine("Victorias: " + victorias[i] + ".");
                            Console.WriteLine("Derrotas: " + derrotas[i] + ".");
                            Console.WriteLine(); //Salto de línea
                        }
                        break;
                }
            } while (eleccion != 6); //Mientras no se escoja el 6, el menú seguirá apareciendo cuando sea indicado

        }

        //Apartado del menú donde puedes cambiar las dimensiones del tablero así como los nombres de los jugadores (incluido el de la IA)
        static void Personalizar(ref int numero_filas, ref int numero_piedras, ref int[] tablero, ref int eleccion, ref string j1, ref string j2, bool PvP)
        {
            do
            {
                Console.WriteLine("1. Cambiar número de filas. Actual: " + numero_filas + ".");
                Console.WriteLine("2. Cambiar número de piedras. Actual: " + numero_piedras + ".");
                Console.WriteLine("3. Cambiar nombre del 1º jugador. Actual: " + j1 + ".");
                Console.Write("4. Cambiar nombre del 2º jugador. Actual: " + j2 + ".");
                //Marca si se trata de una máquina o no
                if (PvP == false)
                {
                    Console.Write(" (MÁQUINA)");
                }
                Console.WriteLine(); //Salto de línea
                Console.WriteLine("5. Salir.");
                //Se evita que se responda con ninguna respuesta indeseada
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 5)
                {
                    Console.WriteLine("Inserte una opción válida.");
                }
                //El programa toma un camino dependiendo del número escogido
                switch (eleccion)
                {
                    case 1:
                        //Se cambia la altura del tablero
                        Console.WriteLine("¿Cuántas filas va a haber en el juego?");
                        while (!int.TryParse(Console.ReadLine(), out numero_filas))
                        {
                            Console.WriteLine("Inserte una opción válida.");
                        }
                        tablero = new int[numero_filas];
                        Console.Clear(); //Limpiar la pantalla
                        break;
                    case 2:
                        //Se cambia la anchura del tablero
                        Console.WriteLine("¿Cuántas piedras va a haber por fila?");
                        while (!int.TryParse(Console.ReadLine(), out numero_piedras))
                        {
                            Console.WriteLine("Inserte una opción válida.");
                        }
                        Console.Clear(); //Limpiar la pantalla
                        break;
                    case 3:
                        //Se cambia el nombre del 1º jugador
                        Console.WriteLine("¿Cuál es el nombre del 1º jugador?");
                        j1 = Console.ReadLine();
                        Console.Clear(); //Limpiar la pantalla
                        break;
                    case 4:
                        //Se cambia el nombre del 2º jugador o IA
                        Console.WriteLine("¿Cuál es el nombre del 2º jugador?");
                        j2 = Console.ReadLine();
                        Console.Clear(); //Limpiar la pantalla
                        break;
                }
            } while (eleccion != 5); //Mientras no se escoja el 5, se pueden aplicar todos los cambios deseados
            Console.Clear(); //Limpiar la pantalla
        }

        //Apartado del menu donde se cambia el modo de juego, entre PvP o PvE
        static void ModoDeJuego(ref int eleccion, ref bool PvP)
        {
            do
            {
                Console.Write("1. Jugador contra jugador. ");
                //Marca la situación actual del modo de juego
                if (PvP == true)
                {
                    Console.Write("(ACTUAL)");
                }
                Console.WriteLine();
                Console.Write("2. Jugador contra máquina. ");
                if (PvP == false)
                {
                    Console.Write("(ACTUAL)");
                }
                Console.WriteLine();
                Console.WriteLine("3. Salir.");
                //Se evita que se responda con ninguna respuesta indeseada
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 3)
                {
                    Console.WriteLine("Inserte una opción válida.");
                }
                //El programa toma un camino dependiendo del número escogido
                switch (eleccion)
                {
                    case 1:
                        PvP = true;
                        Console.Clear(); //Limpiar la pantalla
                        break;
                    case 2:
                        PvP = false;
                        Console.Clear(); //Limpiar la pantalla
                        break;
                }
            } while (eleccion != 3); //Mientras no se escoja el 3, se pueden cambiar indefinidamente el modo de juego
            Console.Clear(); //Limpiar la pantalla
        }

        //Pantalla principal de juego, donde se decide el orden de los jugadores y se procede a jugar
        static void Jugar(int numero_piedras, int[] tablero, int filas, int piedras, int turnos, ref int eleccion, string[] nombres, int[] victorias, int[] derrotas, string jugador, string j1, string j2, bool PvP, ref bool fin_partida)
        {
            Console.WriteLine("¿Qué jugador empezará primero?");
            Console.WriteLine("1. " + j1 + ".");
            Console.Write("2. " + j2 + ".");
            //Marca si se trata de una máquina o no
            if (PvP == false)
            {
                Console.Write(" (MÁQUINA)");
            }
            Console.WriteLine();
            //Se evita que se responda con ninguna respuesta indeseada
            while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 2)
            {
                Console.WriteLine("Inserte una opción válida.");
            }
            if (eleccion == 1)
            {
                if (PvP == true)
                {
                    do
                    {
                        //Empieza el 1º jugador humano y le sigue el 2º
                        TurnoHumano(numero_piedras, tablero, ref filas, ref piedras, ref turnos, nombres, victorias, derrotas, ref jugador, j1, j2, PvP, ref fin_partida);
                    } while (fin_partida == false);
                }
                else
                {
                    do
                    {
                        //Empieza el jugador humano y le sigue la máquina
                        while (turnos % 2 != 0 && fin_partida == false)
                        {
                            TurnoHumano(numero_piedras, tablero, ref filas, ref piedras, ref turnos, nombres, victorias, derrotas, ref jugador, j1, j2, PvP, ref fin_partida);
                        }
                        while (turnos % 2 == 0 && fin_partida == false)
                        {
                            TurnoMáquina(numero_piedras, tablero, ref filas, ref piedras, ref turnos, nombres, victorias, derrotas, ref jugador, j1, j2, PvP, ref fin_partida);
                        }
                    } while (fin_partida == false);
                }

            }
            else
            {
                if (PvP == true)
                {
                    do
                    {
                        //Empieza el 2º jugador humano y le sigue el 1º
                        TurnoHumano(numero_piedras, tablero, ref filas, ref piedras, ref turnos, nombres, victorias, derrotas, ref jugador, j2, j1, PvP, ref fin_partida);
                    } while (fin_partida == false);
                }
                else
                {
                    do
                    {
                        //Empieza el jugador humano y le sigue la máquina
                        while (turnos % 2 != 0 && fin_partida == false)
                        {
                            TurnoMáquina(numero_piedras, tablero, ref filas, ref piedras, ref turnos, nombres, victorias, derrotas, ref jugador, j2, j1, PvP, ref fin_partida);
                        }
                        while (turnos % 2 == 0 && fin_partida == false)
                        {
                            TurnoHumano(numero_piedras, tablero, ref filas, ref piedras, ref turnos, nombres, victorias, derrotas, ref jugador, j2, j1, PvP, ref fin_partida);
                        }
                    } while (fin_partida == false);
                }
            }
        }

        //Función que dicta el proceso que tomará un jugador humano en su turno
        static void TurnoHumano(int numero_piedras, int[] tablero, ref int filas, ref int piedras, ref int turnos, string[] nombres, int[] victorias, int[] derrotas, ref string jugador, string j1, string j2, bool PvP, ref bool fin_partida)
        {
            //Inicializar el tablero
            if (turnos == 1)
            {
                for (int i = 0; i < tablero.Length; i++)
                {
                    tablero[i] = numero_piedras;
                }

            }
            //Establecer el turno
            if (turnos % 2 == 0)
            {
                jugador = j2;
            }
            else
            {
                jugador = j1;
            }

            Console.WriteLine("Turno de " + jugador + ".");

            //Sacar por pantalla el tablero
            for (int i = 0; i < tablero.Length; i++)
            {
                for (int j = 0; j < tablero[i]; j++)
                {
                    Console.Write("O ");
                }
                Console.WriteLine(); //Salto de línea
            }

            //Realizar jugada
            //Se solicita al usuario fila y el número de piedras que quita
            Console.WriteLine("¿De qué fila deseas quitar piedras?");
            //Validar los datos
            while (!int.TryParse(Console.ReadLine(), out filas) || filas < 1 || filas > tablero.Length || tablero[filas - 1] == 0)
            {
                Console.WriteLine("Inserte una opción válida.");
            }
            Console.WriteLine("¿Cuántas piedras deseas quitar?");
            //Validar los datos
            while (!int.TryParse(Console.ReadLine(), out piedras) || piedras < 1 || piedras > tablero[filas - 1])
            {
                Console.WriteLine("Inserte una opción válida.");
            }
            tablero[filas - 1] -= piedras;

            //Limpiar la pantalla
            Console.Clear();

            int contador0 = 0;
            int contador1 = 0;
            int contador2 = 0;

            //Llama a la función que calcula las piedras restantes
            PiedrasRestantes(tablero, ref contador0, ref contador1, ref contador2);

            //Si es 0 o 1 --> fin de la partida
            if (contador0 == tablero.Length - 1 && contador1 == 1)
            {
                //Muestra mensaje de victoria
                Console.WriteLine("¡Se acabó la partida!");
                Console.WriteLine("El ganador es " + jugador + ".");
                Console.WriteLine("¡FELICIDADES!");
                Console.WriteLine(); //Salto de línea
                if (jugador == j1)
                {
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j1 el ganador
                    HighScore(j1, j2, nombres, victorias, derrotas);
                }
                else
                {
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j2 el ganador
                    HighScore(j2, j1, nombres, victorias, derrotas);
                }
                turnos = 1; //Reseteo de turnos
                fin_partida = true; //Marca que la partida ha acabado
            }
            else if (contador0 == tablero.Length)
            {
                //Muestra mensaje de victoria
                Console.WriteLine("¡Se acabó la partida!");
                if (jugador == j1)
                {
                    Console.WriteLine("El ganador es " + j2 + ".");
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j2 el ganador
                    HighScore(j2, j1, nombres, victorias, derrotas);
                }
                else
                {
                    Console.WriteLine("El ganador es " + j1 + ".");
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j1 el ganador
                    HighScore(j1, j2, nombres, victorias, derrotas);
                }
                Console.WriteLine("¡FELICIDADES!");
                Console.WriteLine(); //Salto de línea
                turnos = 1; //Reseteo de turnos
                fin_partida = true; //Marca que la partida ha acabado
            }
            turnos++; //De no terminar la partida, añade 1 al contador de turnos
        }

        //Comprueba el número de piedras que quedan
        static void PiedrasRestantes(int[] tablero, ref int contador0, ref int contador1, ref int contador2)
        {

            for (int i = 0; i < tablero.Length; i++)
            {
                if (tablero[i] == 0)
                {
                    contador0++;
                }
                else if (tablero[i] == 1)
                {
                    contador1++;
                }
                else if (tablero[i] == 2)
                {
                    contador2++;
                }
            }
        }


        //Función que registra hasta 10 jugadores y todas las veces que han ganado o perdido
        static void HighScore(string vencedor, string perdedor, string[] nombres, int[] victorias, int[] derrotas)
        {
            int contador = 0;

            //Registra al ganador primero
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == "" || nombres[i] == vencedor)
                {
                    if (contador == 0)
                    {
                        nombres[i] = vencedor;
                        victorias[i]++;
                        contador++;
                    }
                }
            }
            contador = 0;

            //Registra al perdedor segundo
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == "" || nombres[i] == perdedor)
                {
                    if (contador == 0)
                    {
                        nombres[i] = perdedor;
                        derrotas[i]++;
                        contador++;
                    }
                }
            }
        }

        //Función que dicta el proceso que tomará la máquina en su turno
        static void TurnoMáquina(int numero_piedras, int[] tablero, ref int filas, ref int piedras, ref int turnos, string[] nombres, int[] victorias, int[] derrotas, ref string jugador, string j1, string j2, bool PvP, ref bool fin_partida)
        {
            //Inicializar el tablero
            if (turnos == 1)
            {
                for (int i = 0; i < tablero.Length; i++)
                {
                    tablero[i] = numero_piedras;
                }

            }

            //Establecer el turno
            if (turnos % 2 == 0)
            {
                jugador = j2;
            }
            else
            {
                jugador = j1;
            }
            Console.WriteLine("Turno de " + jugador + ".");

            //Sacar por pantalla el tablero
            for (int i = 0; i < tablero.Length; i++)
            {
                for (int j = 0; j < tablero[i]; j++)
                {
                    Console.Write("O ");
                }
                Console.WriteLine(); //Salto de línea
            }

            //Realizar jugada
            //Se solicita al usuario fila y el número de piedras que quita
            Console.WriteLine("¿De qué fila deseas quitar piedras?");
            //Validar los datos
            int contador0 = 0;
            int contador1 = 0;
            int contador2 = 0;

            //Llama a la función que calcula las piedras restantes
            PiedrasRestantes(tablero, ref contador0, ref contador1, ref contador2);

            //De solo quedar DOS filas, con UNA sola teniendo una piedra, quitará todas las de la otra para ganar
            if (contador0 == tablero.Length - 2 && contador1 == 1)
            {
                do
                {
                    Random rand1 = new Random();
                    filas = rand1.Next(1, tablero.Length + 1);
                } while (tablero[filas - 1] <= 1);
                Console.WriteLine(filas);
                Console.WriteLine("¿Cuántas piedras deseas quitar?");
                piedras = tablero[filas - 1];
            }
            //De solo quedar DOS filas, con NINGUNA teniendo una sola piedra, NI las dos teniendo dos cada una, quitará de la otra fila de haber una con solo dos piedras y SIEMPRE dejará dos piedras mínimo para evitar perder
            else if (contador0 == tablero.Length - 2 && contador1 == 0 && contador2 != 2)
            {
                do
                {
                    Random rand1 = new Random();
                    filas = rand1.Next(1, tablero.Length + 1);
                } while (tablero[filas - 1] <= 2);
                Console.WriteLine(filas);
                Console.WriteLine("¿Cuántas piedras deseas quitar?");
                Random rand2 = new Random();
                piedras = rand2.Next(1, tablero[filas - 1] - 1);
            } 
            else
            {
                //Movimientos aleatorios
                do
                {
                    Random rand1 = new Random();
                    filas = rand1.Next(1, tablero.Length + 1);
                } while (tablero[filas - 1] == 0);
                Console.WriteLine(filas);
                Console.WriteLine("¿Cuántas piedras deseas quitar?");
                //Validar los datos

                //De solo quedar UNA fila, quitará todas las piedras salvo una para ganar
                if (contador0 == tablero.Length - 1)
                {
                    piedras = tablero[filas - 1] - 1;
                }
                //Movimientos aleatorios 
                else
                {
                    Random rand2 = new Random();
                    piedras = rand2.Next(1, tablero[filas - 1] + 1);
                }
            }
            Console.WriteLine(piedras);
            tablero[filas - 1] -= piedras;

            //Pausa
            Console.ReadKey();

            //Limpiar la pantalla
            Console.Clear();

            contador0 = 0;
            contador1 = 0;
            contador2 = 0;

            //Llama a la función que calcula las piedras restantes
            PiedrasRestantes(tablero, ref contador0, ref contador1, ref contador2);

            //Si es 0 o 1 --> fin de la partida
            if (contador0 == tablero.Length - 1 && contador1 == 1)
            {
                //Muestra mensaje de victoria
                Console.WriteLine("¡Se acabó la partida!");
                Console.WriteLine("El ganador es " + jugador + ".");
                Console.WriteLine("¡FELICIDADES!");
                Console.WriteLine(); //Salto de línea
                if (jugador == j1)
                {
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j1 el ganador
                    HighScore(j1, j2, nombres, victorias, derrotas);
                }
                else
                {
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j2 el ganador
                    HighScore(j2, j1, nombres, victorias, derrotas);
                }
                turnos = 1; //Reseteo de turnos
                fin_partida = true; //Marca que la partida ha acabado
            }
            else if (contador0 == tablero.Length)
            {
                //Muestra mensaje de victoria
                Console.WriteLine("¡Se acabó la partida!");
                if (jugador == j1)
                {
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j2 el ganador
                    Console.WriteLine("El ganador es " + j2 + ".");
                    HighScore(j2, j1, nombres, victorias, derrotas);
                }
                else
                {
                    Console.WriteLine("El ganador es " + j1 + ".");
                    //Llamar la función que registra las puntuaciones en el High Score, siendo j1 el ganador
                    HighScore(j1, j2, nombres, victorias, derrotas);
                }
                Console.WriteLine("¡FELICIDADES!");
                Console.WriteLine(); //Salto de línea
                turnos = 1; //Reseteo de turnos
                fin_partida = true; //Marca que la partida ha acabado
            }
            turnos++; //De no terminar la partida, añade 1 al contador de turnos
        }
    }
}

