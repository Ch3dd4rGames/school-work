using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacroExamen
{
    class TareaAdministrativa : Tarea
    {
        protected const int MIN_DURACION = 10;
        protected const int MAX_DURACION = 120;

        public TareaAdministrativa(int _id, int _tipo = -1) : base(_id, _tipo)
        {
            Tipo = "Administrativa";
            //generamos el coste de tiempo aleatoriamente en función del tipo de tarea

            CosteTiempo = aleatorio.Next(MIN_DURACION / 5, (MAX_DURACION + 1) / 5);
            CosteTiempo *= 5;
        }
    }
}
