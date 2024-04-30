using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacroExamen
{
    //NOTA: EL ENUNCIADO DEL EXAMEN NO PIDE LA GESTIÓN DE LAS TAREAS REALIZADAS POR EL TRABAJADOR, PERO ESTE PROGRAMA LAS INCLUYE

    class Trabajador
    {
        
        public const int TiempoJornadaLaboral = 480; //8 horas de trabajo * 60 minutos que tiene cada hora
        public string Nombre { get; private set; }
        public int TiempoDisponible { get; private set; }
        Tarea[] TareasRealizadas = new Tarea[1000];//se irán añadiendo las tareas que ha realizado el trabajador. 
        int ContadorTareas;//Nº de tareas que ha realizado el trabajador


        public void NuevaJornadaLaboral() {
            //se reinicia el contador de tiempo disponible
            TiempoDisponible = TiempoJornadaLaboral;
          
        }

        public Trabajador(string _nombre) {
            Nombre = _nombre;
            ContadorTareas = 0;
            NuevaJornadaLaboral();
        }

        public bool AsignarTarea(Tarea t) {
            //esta función intenta asignar la tarea t al trabajador. Si es posible, retorna true, si no, false.
            if (!t.Realizada && t.CosteTiempo <= TiempoDisponible && ContadorTareas < TareasRealizadas.Length)
            {
                t.HacerTarea();
                TiempoDisponible -= t.CosteTiempo;//se le resta al tiempo disponible el tiempo que ha costado hacer la tarea
                TareasRealizadas[ContadorTareas] = t;//se añade la tarea a la última posición del array
                ++ContadorTareas;//se incrementa el contador de tareas realizadas
                Console.WriteLine("Tarea "+t.Id+" ha sido realizada por el trabajador "+Nombre);
                return true;
            }
            else {
                Console.Write("La tarea " + t.Id + " no se pudo realizar. ");
                if (t.Realizada)
                    Console.WriteLine("Esa tarea ya ha sido realizada");
                if (t.CosteTiempo > TiempoDisponible){
                    Console.WriteLine("El trabajador " + Nombre + " no dispone de tiempo suficiente para realizar la tarea. ");
                    Console.Write("Tiempo disponible: "+ TiempoDisponible+" minutos. ");
                    Console.WriteLine("Coste en tiempo de la tarea {0}: {1} minutos", t.Id, t.CosteTiempo);
                }
                

                return false;
            }
        }

        public void MostrarTareasRealizadas() {
            if (ContadorTareas == 0)
            {
                Console.WriteLine("El trabajador aún no ha realizado ninguna tarea");
            }
            else {
                Console.WriteLine("El trabajador " + Nombre + " ha realizado las siguientes tareas: "); 
                for (int i = 0; i < ContadorTareas; ++i) {
                    TareasRealizadas[i].MostrarInfo();
                }
            }
            
        }


    }
}
