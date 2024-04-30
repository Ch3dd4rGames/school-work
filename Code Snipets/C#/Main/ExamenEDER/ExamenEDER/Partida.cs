using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenEDER
{
    class Partida
    {
        Monstruo[] ListaMonstruos = new Monstruo[10];
        Brujo jugador;

        public Partida()
        {
            Random rand = new Random();
            //Se genera el brujo
            jugador = new Brujo();
            Console.Write("¡El BRUJO ha hecho acto de presencia! ");
            Console.WriteLine("\n");

            //Se generan los monstruos
            for (int i = 0; i < ListaMonstruos.Length; ++i)
            {
                Console.WriteLine("\tMonstruo {0} creado.", i + 1);

                if (rand.Next(0, 2) == 0) //Aleatorio entre 0 y 1
                    ListaMonstruos[i] = new Vampiro(i);
                else
                    ListaMonstruos[i] = new Espectro(i);

                Console.WriteLine("\tTipo: " + ListaMonstruos[i].Tipo);
            }
            Console.WriteLine("\nPulse una tecla para continuar..."); Console.ReadKey();

            int opc;
            do
            {
                opc = Menu();
                switch (opc)
                {
                    case 1:
                        MostrarMonstruos();
                        break;

                    case 2:
                        AtacarMonstruo();
                        break;

                    case 3:
                        jugador.MostrarTareasRealizadas();//esto no lo pide el enunciado
                        break;
                }

                Console.WriteLine("\nPulse una tecla para continuar..."); Console.ReadKey();
            } while (opc != 3);

        }

        private int Menu()
        {

            int opc;
            Console.Clear();
            Console.WriteLine("El brujo dispone de " + jugador.Vida + " PUNTOS DE VIDA y " + jugador.PuntosDeExperiencia + " PUNTOS DE EXPERIENCIA.");
            Console.WriteLine("\nMENÚ PRINCIPAL");
            Console.WriteLine("1 - Mostrar lista de monstruos");
            Console.WriteLine("2 - Atacar monstruo");
            Console.WriteLine("3 - Salir del programa");
            while (!int.TryParse(Console.ReadLine(), out opc) || opc < 1 || opc > 3)
                Console.Write("Opición incorrecta, inserta una opción válida: ");

            Console.WriteLine("\n");
            return opc;
        }

        private void MostrarMonstruos()
        {
            for (int i = 0; i < ListaMonstruos.Length; ++i)
                ListaMonstruos[i].MostrarInfo();
        }


        private void AtacarMonstruo()
        {
            int t;
            Console.Write("Escoge el monstruo que vas a atacar: ");
            while (!int.TryParse(Console.ReadLine(), out t) || t < 0 || t >= ListaMonstruos.Length)
            {
                Console.Write("Valor insertado no válido, inserta un nº entre {0} y {1}: ", 0, ListaMonstruos.Length - 1);
            }

            jugador.AtacarMonstruo(ListaMonstruos[t]);
        }
    }
}
