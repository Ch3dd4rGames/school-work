using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenEDER
{
    class Espectro : Monstruo
    {
        protected int PuntosDeVida;
        protected const int DAÑO = 1;
        protected int Experiencia;

        public Espectro(int _nombre, int _tipo = -1) : base(_nombre, _tipo)
        {
            Tipo = "Espectro";
            //Generamos los puntos de vida aleatoriamente en función del tipo de monstruo
            PuntosDeVida = aleatorio.Next(1, 6);
            Experiencia = PuntosDeVida * 20;
        }
    }
}
