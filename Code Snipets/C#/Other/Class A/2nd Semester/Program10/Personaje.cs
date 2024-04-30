using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal abstract class Personaje
    {//Las caracteristicas genéricas de cualquier personaje

        public const int ExperienciaNivel = 1000;
        protected int Nivel;
        private int PuntosExperiencia;
        protected int Vida;
        protected int MaxVida;
        protected string Nombre;

        public Personaje()
        {
            MaxVida = 100;
            Nivel = 1;
            PuntosExperiencia = 0;
            Console.WriteLine("Escribe el nombre de este personaje: ");
            Nombre = Console.ReadLine();
        }

        public int Menu()
        {
            int Eleccion;
            //Permite al usuario elegir qué quiere hacer
            Console.WriteLine("Escoge que acción deseas tomar: ");
            Console.WriteLine("1. Atacar.");
            Console.WriteLine("2. Descansar.");
            while (!int.TryParse(Console.ReadLine(), out Eleccion) || Eleccion < 1 || Eleccion > 2)
            {
                Console.WriteLine("Escoge una acción válida.");
            }

            //Atacar
            if (Eleccion == 1)
                Atacar();
            //Descansar --> añade Energía o Mana según lo que sea
            else
                Descansar();
        }

        public virtual bool GanarExperiencia(int Experiencia)
        {
            //Añade la experiencia recibida al valor PuntosExperiencia
            PuntosExperiencia += Experiencia;

            //Si la experiencia supera determinado valor, sube de nivel
            if (PuntosExperiencia >= ExperienciaNivel * Nivel)
            {
                Nivel++;
                PuntosExperiencia -= ExperienciaNivel * Nivel;//Reinicia los puntos de experiencia, dejando solo los que sobraban si hubiera
                return true;
            }
            else
                return false;
        }

        public abstract int Atacar();
        public abstract void Descansar();
        public abstract void IniciarCombate();
        public abstract void MostrarStats();

        public bool RecibirAtaque(int daño)
        {
            bool HaMuerto = true;
            Vida -= daño;
            if (Vida < 0)
                HaMuerto = false;

            return HaMuerto;
        }
    }
}
