using System;

namespace ExamenExtraordinariaEDER
//Creado por Eder Cajigas Encina
{
    class Program
    {
        static void Main(string[] args)
        {
            //int eleccion; Para tomar decisiones en el menú
            //int madera; Para marcar la cantidad de madera de la que dispones
            //int mineral; Para marcar la cantidad de mineral del que dispones
            //int serreria; Para marcar la cantidad de serrerías en tu poblado
            //int mineral; Para marcar la cantidad de minas en tu poblado

            //Llamar al menú principal por primera vez, con los valores iniciales
            MenúPrincipal(0, 100, 100, 0, 0);
        }

        // Función para sacar en pantalla la cantidad de recursos actual, así como que edificios se encuentran en el poblado
        static void HUD(ref int madera, ref int mineral, ref int serreria, ref int mina)
        {
            Console.WriteLine("Madera: " + madera); //Saca por pantalla la cantidad de madera
            Console.WriteLine("Minerales: " + mineral); //Saca por pantalla la cantidad de minerales
            Console.WriteLine("Serrerías: " + serreria); //Saca por pantalla la cantidad de serrerias
            Console.WriteLine("Minas: " + mina); //Saca por pantalla la cantidad de minas
        }

        //Interfaz principal del programa
        static void MenúPrincipal(int eleccion, int madera, int mineral, int serreria, int mina)
        {
            do
            {
                Console.Clear(); //Limpiar la pantalla
                //Llamar a la interfaz que informa sobre el dinero y los objetos poseídos
                HUD(ref madera, ref mineral, ref serreria, ref mina);
                Console.WriteLine(); //Salto de línea
                Console.WriteLine("1. Recolectar madera.");
                Console.WriteLine("2. Picar mineral.");
                Console.WriteLine("3. Construir Serrería.");
                Console.WriteLine("4. Construir Mina.");
                Console.WriteLine("5. Salir.");
                //Se evita que se responda con ninguna respuesta indeseada
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 5)
                {
                    Console.WriteLine("Inserte un número válido.");
                }
                //El programa toma un camino dependiendo del número escogido
                switch (eleccion)
                {
                    case 1:
                        //Llamar a la función para recolectar madera
                        RecolectarMadera(ref madera, ref serreria);
                        break;
                    case 2:
                        //Llamar a la función para picar mineral
                        PicarMineral(ref mineral, ref mina);
                        break;
                    case 3:
                        //Se asegura de que haya recursos suficientes para construir la serrería
                        if (madera < 30 || mineral < 10)
                        {
                            Console.WriteLine("No tienes suficientes recursos para construir una serrería.");
                        }
                        else
                        {
                            //Llamar a la función para construir una serrería
                            ConstruirSerreria(ref madera, ref mineral, ref serreria);
                        }
                        break;
                    case 4:
                        //Se asegura de que haya recursos suficientes para construir la mina
                        if (madera < 10 || mineral < 30)
                        {
                            Console.WriteLine("No tienes suficientes recursos para construir una mina.");
                        }
                        else
                        {
                            //Llamar a la función para construir una mina
                            ConstruirMina(ref madera, ref mineral, ref mina);
                        }
                        break;
                }
                Console.ReadKey(); //Pausa
            } while (eleccion != 5); //Mientras no se escoja el 5, el menú seguirá apareciendo cuando sea indicado           
        }

        //Función que lleva a cabo la recolección de madera
        static void RecolectarMadera(ref int madera, ref int serreria)
        {
            int maderaConseguida = 3 + (2 * serreria); //Consigue 3 de madera de base más 2 por cada serrería
            Console.WriteLine("Has conseguido " + maderaConseguida + " de madera."); //Informa de la cantidad de madera que se ha conseguido esta vez
            madera += maderaConseguida; //Añade lo conseguido a la cuenta total de madera
        }

        //Función que lleva a cabo la extracción de mineral
        static void PicarMineral(ref int mineral, ref int mina)
        {
            Random rand = new Random();
            int mineralConseguido = rand.Next(1, 6) + (5 * mina); //Consigue un número aleatorio del 1 al 5 de mineral de base más 5 por cada mina
            Console.WriteLine("Has conseguido " + mineralConseguido + " de mineral."); //Informa de la cantidad de mineral que se ha conseguido esta vez
            mineral += mineralConseguido; //Añade lo conseguido a la cuenta total de mineral
        }

        //Función que lleva a cabo la construcción de una serrería
        static void ConstruirSerreria(ref int madera, ref int mineral, ref int serreria)
        {
            //Se quitan los recursos acordes
            madera -= 30;
            mineral -= 10;
            Console.WriteLine("Has construido una nueva serrería a cambio de 30 de madera y 10 de mineral."); //Se informa al jugador
            serreria += 1; //Se añade 1 a la cantidad de serrerías en el poblado
        }

        //Función que lleva a cabo la construcción de una mina
        static void ConstruirMina(ref int madera, ref int mineral, ref int mina)
        {
            //Se quitan los recursos acordes
            madera -= 10;
            mineral -= 30;
            Console.WriteLine("Has construido una nueva mina a cambio de 10 de madera y 30 de mineral."); //Se informa al jugador
            mina += 1; //Se añade 1 a la cantidad de minas en el poblado
        }
    }
}
