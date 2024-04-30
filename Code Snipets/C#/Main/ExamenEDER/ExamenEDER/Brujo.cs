using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenEDER
{
    class Brujo
    {
        public int Vida;
        public int PuntosDeExperiencia { get; private set; } = 0;
        Monstruo[] MonstruosDerrotados = new Monstruo[1000]; //Se irán añadiendo los monstruos que ha derrotado el brujo. 
        int ContadorMonstruos;//Nº demonstruos que ha realizado el brujo.


        public void NuevaPartida()
        {
            //se reinicia el medidor de vida
            Random rand = new Random();
            Vida = rand.Next(100, 151);

        }

        public Brujo()
        {
            ContadorMonstruos = 0;
            NuevaPartida();
        }

        public bool AtacarMonstruo(Monstruo m)
        {
            //esta función intenta asignar el monstruo m al brujo. Si es posible, retorna true, si no, false.
            if (!m.Derrotado && m.Daño <= PuntosDeExperiencia && ContadorMonstruos < MonstruosDerrotados.Length)
            {
                m.HacerTarea();
                PuntosDeExperiencia -= m.Daño;//se le resta al tiempo disponible el tiempo que ha costado hacer la tarea
                MonstruosDerrotados[ContadorMonstruos] = m;//se añade la tarea a la última posición del array
                ++ContadorMonstruos;//se incrementa el contador de tareas realizadas
                Console.WriteLine(m.Tipo + " ha sido derrotado por el brujo.");
                return true;
            }
            else
            {
                Console.Write("La tarea " + m.Numero + " no se pudo derrotar. ");
                if (m.Derrotado)
                    Console.WriteLine("Esa monstruo ya ha sido derrotado");
                if (m.Daño > PuntosDeExperiencia)
                {
                    Console.WriteLine("El brujo ha sido derrotado... ");
                    Console.Write("Experiencia: " + PuntosDeExperiencia + " puntos. ");
                }


                return false;
            }
        }

        public void MostrarTareasRealizadas()
        {
            if (ContadorMonstruos == 0)
            {
                Console.WriteLine("El brujo aún no ha derrotado a ningún monstruo.");
            }
            else
            {
                Console.WriteLine("El brujo derrotó a los siguientes monstruos: ");
                for (int i = 0; i < ContadorMonstruos; ++i)
                {
                    MonstruosDerrotados[i].MostrarInfo();
                }
            }

        }
    }
}
