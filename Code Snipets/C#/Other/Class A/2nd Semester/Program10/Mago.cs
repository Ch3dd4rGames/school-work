using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Mago : Personaje
    {
        const int MaxMana = 30;
        int Mana;
        int Inteligencia;

        //Constructor
        public Mago()
        {
            Inteligencia = 15;
            Console.WriteLine("El mago {0} ha sido invocado.", Nombre);
        }

        public override void MostrarStats()
        {
            Console.WriteLine("Mago {0} de nivel {1}.", Nombre, Nivel);
            Console.WriteLine("Inteligencia: {0}. Mana {1}.", Inteligencia, Mana);
        }

        public override int Atacar()
        {
            Random Rand = new Random();
            int Dado = Rand.Next(1, 11);
            //El daño será un valor aleatorio combinado con la Inteligencia y el Nivel
            int ValorAtaque = Inteligencia * Nivel * Dado / 10;
            //Solo se puede atacar si tenemos Mana suficiente
            if (ValorAtaque > Mana)
            {
                Console.WriteLine("No tienes maná suficiente para atacar.");
                ValorAtaque = 0;
            }
            else
            {
                //El ataque resta Mana, tanta como daño causa
                Mana -= ValorAtaque;
                Console.WriteLine("El mago lanza un ataque de " + ValorAtaque + " de daño.");
            }
            //El mago ataca y devuelve como valor de retorno el daño que causa
            return ValorAtaque;
        }

        public override bool GanarExperiencia(int Experiencia)
        {
            bool SubeNivel = base.GanarExperiencia(Experiencia);
            if (SubeNivel)
                Inteligencia += 5;
            return SubeNivel;
        }

        public override void Descansar()
        {
            Random Rand = new Random();
            int Dado = Rand.Next(1, 11);
            Mana += 3 * Dado;
            if (Mana > MaxMana * Nivel)
                Mana = MaxMana * Nivel;
        }

        public override void IniciarCombate()
        {
            Vida = MaxVida * Nivel;
            Mana = MaxMana * Nivel;
        }
    }
}
