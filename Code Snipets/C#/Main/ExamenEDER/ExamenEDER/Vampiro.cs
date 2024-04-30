using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenEDER
{
    class Vampiro : Monstruo
    {
        protected int PuntosDeVida;
        protected const int DAÑO = 3;
        protected int Experiencia;

        public Vampiro(int _nombre, int _tipo = -1) : base(_nombre, _tipo)
        {
            Tipo = "Vampiro";           
            //Generamos los puntos de vida aleatoriamente en función del tipo de monstruo
            PuntosDeVida = aleatorio.Next(5, 11);
            Experiencia = PuntosDeVida * 50;
        }
    }
}
