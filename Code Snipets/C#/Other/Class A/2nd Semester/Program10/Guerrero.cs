using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Guerrero : Personaje
    {
        int MaxEnergia;
        int Energia;
        const int Fuerza = 20;

        //Constructor
        public Guerrero()
        {
            MaxEnergia = 25;
        }

        public override int Atacar()
        {
            Random rand = new Random();
            int roll = rand.Next(1, 11);
            //El daño será un valor aleatorio combinado con la Fuerza y el Nivel
            int ValorAtaque = Fuerza * Nivel * roll / 10;
            //Solo se puede atacar si tenemos Energia suficiente
            if (ValorAtaque > Energia)
            {
                Console.WriteLine("No tienes energía suficiente para atacar.");
                return 0;
            }
            else
            {
                //El ataque resta Energia, tanta como daño causa
                Energia -= ValorAtaque;
                //El guerrero ataca y devuelve como valor de retorno el daño que causa
                return ValorAtaque;
            }
        }
    }
}
