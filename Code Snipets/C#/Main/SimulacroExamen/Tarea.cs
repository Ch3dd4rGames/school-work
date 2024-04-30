using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacroExamen
{
    /*                  
                    MIN     MAX
   0 administrativa   5       80 
   1      comercial   10      120
     
     */


    abstract class Tarea
    {
        public Random aleatorio = new Random();

        // static string[] TiposPosibles = { "administrativa", "comercial" };
        // static int[,] MinMaxCosteTiempo = { { 5, 80 }     , { 10, 120 } };//el mínimo y máximo coste de tiempo según el tipo de tarea

        public string Tipo { get; protected set; }
        public bool Realizada  { get; protected set; } //false --> tarea no realizada,  true --> tarea realizada
        public int CosteTiempo { get; protected set; }
        public int Id { get; private set; }//identificador de la tarea
        


        public Tarea(int _id, int _tipo = -1) {
            this.Id = Id;
            aleatorio.Next(0, 3);


            Realizada = false;
        }


       /* public string GetTipoTarea() {
            return TiposPosibles[Tipo];
        }
       */
        public void HacerTarea() {
            //establece la tarea como realizada
            Realizada = true;
        }

        public void MostrarInfo() {
            Console.WriteLine("\nTarea {0}:", Id);
            Console.WriteLine("\tTipo: " + Tipo);
            Console.WriteLine("\tCoste de tiempo de realización: {0}", CosteTiempo);
            Console.Write("\tEstado: ");
            if (Realizada)
                Console.WriteLine("Realizada");
            else
                Console.WriteLine("No realizada");


        }


    }
}
