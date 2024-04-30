using System;

namespace SimulacroExamen
{
    class Sistema
    {
        Tarea[] ListaTareas = new Tarea[10];
        Trabajador currito;

        public Sistema()
        {
            Random rand = new Random();
            //se genera el trabajador
            Console.Write("Hola trabajador, dime tu nombre: ");
            string nombre = Console.ReadLine();
            currito = new Trabajador(nombre);

            //se generan las tareas
            for (int i = 0; i < ListaTareas.Length; ++i) {
                if(rand.Next(0,2) == 0) //aleatorio entre 0 y 1
                   ListaTareas[i] = new TareaComercial(i);
                else
                    ListaTareas[i] = new TareaAdministrativa(i);

                Console.WriteLine("Tarea {0} creada", ListaTareas[i].Id);
                Console.WriteLine("\tTipo: " + ListaTareas[i].Tipo);
                Console.WriteLine("\tCoste de tiempo de realización: {0}\n", ListaTareas[i].CosteTiempo);
            }
            Console.WriteLine("\nPulse una tecla para continuar..."); Console.ReadKey();

            int opc; 
            do {
                opc = Menu();
                switch (opc)
                {
                    case 1:
                        MostrarTareas();
                        break;
                    
                    case 2:
                        AsignarTarea();
                        break;
                    
                    case 3:
                        currito.MostrarTareasRealizadas();//esto no lo pide el enunciado
                        break;
                }

                Console.WriteLine("\nPulse una tecla para continuar...");Console.ReadKey();
            } while (opc != 3);

        }

        private int Menu() {

            int opc;
            Console.Clear();
            Console.WriteLine("El trabajador " + currito.Nombre + " dispone de "+currito.TiempoDisponible+" minutos");
            Console.WriteLine("\nMENÚ PRINCIPAL");
            Console.WriteLine("1 - Mostrar lista de tareas");
            Console.WriteLine("2 - Asignar tarea al trabajador");
            Console.WriteLine("3 - Salir del programa");
            while (!int.TryParse(Console.ReadLine(), out opc) || opc < 1 || opc >3)
                Console.Write("Opición incorrecta, inserta una opción válida: ");

            Console.WriteLine("\n");
            return opc;
        }

        private void MostrarTareas() {
            for (int i = 0; i < ListaTareas.Length; ++i)
                ListaTareas[i].MostrarInfo();


        }


        private void AsignarTarea() {
            int t;
            Console.Write("Escoge la tarea a realizar: ");
            while (!int.TryParse(Console.ReadLine(), out t) || t < 0 || t >= ListaTareas.Length) {
                Console.Write("Valor insertado no válido, inserta un nº entre {0} y {1}: ", 0, ListaTareas.Length - 1);
            }

            currito.AsignarTarea(ListaTareas[t]);
        }
    }
}
