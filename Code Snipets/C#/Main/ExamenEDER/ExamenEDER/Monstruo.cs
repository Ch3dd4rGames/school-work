using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenEDER
{
    abstract class Monstruo
    {
        public Random aleatorio = new Random();

        public string Tipo { get; protected set; }
        public bool Derrotado { get; protected set; } //false --> monstruo no derrotado,  true --> monstruo derrotado
        public int Daño { get; protected set; }
        public int Numero { get; private set; }//Numero del monstruo



        public Monstruo(int _nombre, int _tipo = -1)
        {
            this.Numero = Numero;
            aleatorio.Next(0, 3);


            Derrotado = false;
        }

        public void HacerTarea()
        {
            //Establece el monstruo como derrotado
            Derrotado = true;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("\nTarea {0}:", Numero);
            Console.WriteLine("\tTipo: " + Tipo);
            Console.Write("\tEstado: ");
            if (Derrotado)
                Console.WriteLine("Derrotado");
            else
                Console.WriteLine("No derrotado");


        }
    }
}
