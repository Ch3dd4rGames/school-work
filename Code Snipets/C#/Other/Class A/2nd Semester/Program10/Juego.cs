using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Juego
    {
        int TotalPersonajes = 0;
        Personaje[] Personajes = new Personaje[10];

        public Juego()
        {
            int Eleccion;
            do
            {
                Eleccion = Menu();
                switch (Eleccion)
                {
                    case 1:
                        NuevoPersonaje();
                        break;
                    case 2:
                        NuevoCombate();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                }
                Console.ReadKey();//Pausa
            }while (Eleccion != 3);
        }

        public int Menu()
        {
            int Eleccion;
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine("1 - Crear Personaje.");
            Console.WriteLine("2 - Nuevo Combate.");
            Console.WriteLine("3 - Salir del programa.");
            while (!int.TryParse(Console.ReadLine(), out Eleccion) || Eleccion < 1 || Eleccion > 3)
            {
                Console.Write("Escoge una opción válida.");
            }
            return Eleccion;
        }

        public void NuevoPersonaje()
        {
            if (TotalPersonajes == Personajes.Length)
                Console.WriteLine("No hay hueco para crear personajes nuevos");
            else
            {
                int Eleccion;
                Console.WriteLine("¿Qué personaje quieres crear?");
                Console.WriteLine("1. Guerrero");
                Console.WriteLine("2. Mago");
                while (!int.TryParse(Console.ReadLine(), out Eleccion) || Eleccion < 1 || Eleccion > 2)
                {
                    Console.Write("Escoge una opción válida.");
                }

                if (Eleccion == 1)
                    Personajes[TotalPersonajes] = new Guerrero();
                else
                    Personajes[TotalPersonajes] = new Mago();
            }
        }

        public void NuevoCombate()
        {
            int Eleccion, Daño, Atacante, Defensor;
            if (TotalPersonajes < 2)
            {
                Console.WriteLine("Debe haber al menos dos personajes creados antes de combatir.");
                return;
            }

            Personaje[] Combatientes = new Personaje[2];
            int Jugador1, Jugador2;
            Console.WriteLine("Lista de personajes que puedes escoger: ");
            for (int i = 0; i < TotalPersonajes; i++)
            {
                Console.Write(i + " - ");
                Personajes[i].MostrarStats();
                Console.WriteLine();
            }

            Console.Write("Escoge un personaje para el jugador 1: ");
            while (!int.TryParse(Console.ReadLine(), out Jugador1) || Jugador1 < 0 || Jugador1 >= TotalPersonajes)
            {
                Console.WriteLine("Opción incorrecta. ");
            }
            Combatientes[0] = Personajes[Jugador1];

            Console.Write("Escoge un personaje para el jugador 2: ");
            while (!int.TryParse(Console.ReadLine(), out Jugador2) || Jugador1 == Jugador2 || Jugador2 < 0 || Jugador2 >= TotalPersonajes)
            {
                Console.WriteLine("Opción incorrecta. ");
            }
            Combatientes[1] = Personajes[Jugador2];

            //Bucle del juego
            bool HayMuerte = false;
            Atacante = 0;//Podría ser aleatoria
            Defensor = 1;
            //Ponemos a los combatientes en disposición de iniciar el combate
            Combatientes[0].IniciarCombate();
            Combatientes[1].IniciarCombate();
            do
            {
                //Establecer turno
                if (Atacante == 0)
                {
                    Atacante = 1; Defensor = 0;
                }
                else
                {
                    Atacante = 0; Defensor = 1;
                }

                //El combatiente decide qué hacer
                Eleccion = Combatientes[Atacante].Menu();
                if (Eleccion == 1)//Atacar
                {
                    Daño = Combatientes[Atacante].Atacar();
                    HayMuerte = Combatientes[Defensor].RecibirAtaque(Daño);
                }
                else if (Eleccion == 2)
                    Combatientes[Atacante].Descansar();
            }while (!HayMuerte);//Si se sale del bucle es porque el atacante ha ganado

            Combatientes[Atacante].GanarExperiencia(500);
            //Guardar los personajes en su posición para el siguiente combate
            Personajes[Jugador1] = Combatientes[0];
            Personajes[Jugador2] = Combatientes[1];
        }
    }
}
