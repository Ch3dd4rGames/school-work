using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacroExamen
{
    class TareaComercial : Tarea
    {
        protected const int MIN_DURACION = 5;
        protected const int MAX_DURACION = 80;

        public TareaComercial(int _id, int _tipo = -1) : base(_id, _tipo) {

            Tipo = "Comercial";
            //generamos el coste de tiempo aleatoriamente en función del tipo de tarea

            CosteTiempo = aleatorio.Next(MIN_DURACION / 5, (MAX_DURACION + 1) / 5);
            CosteTiempo *= 5;
        }
    }
}
