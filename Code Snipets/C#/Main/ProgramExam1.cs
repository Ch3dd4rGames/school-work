using System;

namespace Examen1EDER
//Creado por Eder Cajigas Encina
{
    class Program
    {
        static void Main(string[] args)
        {
            //int eleccion; Para tomar decisiones en el menú
            //int dinero; Para marcar la cantidad de dinero del que dispones
            //string nombre; Para marcar el nombre de los objetos
            string[] inventario = new string[5]; //Para guardar los nombres de los objetos en el HUD
            //int objetos; Para marcar la cantidad de objetos en el inventario
            //int espada, int arco, int escudo, int armadura, int casco; Para asignar los precios de cada uno de los objetos

            //Llamar al inventario inicial para asignarle sus valores predeterminados
            StartingInventory(inventario);

            //Llamar al menú principal por primera vez, con los valores iniciales, así como llamar a la función que asigna los precios
            MenúPrincipal(0, 1000, "Nada", inventario, 0, AsignarPrecio(), AsignarPrecio(), AsignarPrecio(), AsignarPrecio(), AsignarPrecio());
        }

        //Función de asignación de valores del array del inventario
        static void StartingInventory(string[] inventario)
        {
            //Asigna vacío a todos los espacios del inventario
            for (int i = 0; i < inventario.Length; i++)
            {
                inventario[i] = "";
            }
        }

        //Función para asignar los precios de cada uno de los objetos, de manera aleatoria
        public static int AsignarPrecio()
        {
            Random rand = new Random();
            int precio = rand.Next(2, 11); //Escoge un número aleatorio del 2 al 10
            return precio * 10; //Devuelve el valor multiplicado por 10 para que sea múltiplo de 10
        }

        // Función para sacar en pantalla la cantidad de dinero actual, así como que objetos se encuentran en el inventario
        static void HUD(ref int dinero, string[] inventario)
        {
            Console.WriteLine("Dinero: " + dinero + "$"); //Saca por pantalla la cantidad de dinero
            //Saca por pantalla la lista de objetos, ordenados por el valor correspondiente de cada espacio
            for (int i = 0; i < inventario.Length; i++)
            {
                Console.WriteLine("Objeto " + (i + 1) + ": " + inventario[i]);
            }

        }

        //Interfaz principal del programa
        static void MenúPrincipal(int eleccion, int dinero, string nombre, string[] inventario, int objetos, int espada, int arco, int escudo, int armadura, int casco)
        {
            do
            {
                Console.Clear(); //Limpiar la pantalla
                //Llamar a la interfaz que informa sobre el dinero y los objetos poseídos
                HUD(ref dinero, inventario);
                Console.WriteLine(); //Salto de línea
                Console.WriteLine("¡Bienvenido a mi tienda! ¿Qué es lo que quieres hacer hoy?");
                Console.WriteLine("1. Comprar objeto.");
                Console.WriteLine("2. Vender objeto.");
                Console.WriteLine("3. Salir.");
                //Se evita que se responda con ninguna respuesta indeseada
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 3)
                {
                    Console.WriteLine("¿Qué se supone que significa eso?");
                }
                //El programa toma un camino dependiendo del número escogido
                switch (eleccion)
                {
                    case 1:
                        //Se asegura de que haya espacio suficiente en el inventario como para poder comprar nada
                        if (objetos == inventario.Length)
                        {
                            Console.WriteLine("No tienes espacio en tu inventario para comprar nada.");
                            Console.ReadKey(); //Pausa
                        }
                        else
                        {
                            Console.Clear(); //Limpiar la pantalla

                            //Llamar al menú de compra, con el que se pueden comprar distintos objetos a distintos precios
                            TiendaCompra(ref eleccion, ref dinero, nombre, inventario, ref objetos, espada, arco, escudo, armadura, casco);

                            //Se asegura de que, de haber escogido el escudo (3) como último objeto del inventario, el programa no termine por error
                            if (objetos == inventario.Length)
                            {
                                eleccion = 0;
                            }
                        }
                        break;
                    case 2:
                        //Se asegura de que haya algo en el inventario como para poder vender nada
                        if (objetos == 0)
                        {
                            Console.WriteLine("No tienes nada para vender.");
                            Console.ReadKey(); //Pausa
                        }
                        else
                        {
                            Console.Clear(); //Limpiar la pantalla

                            //Llamar al menú de venta, con el que se pueden vender distintos objetos a distintos precios
                            TiendaVenta(ref eleccion, ref dinero, nombre, inventario, ref objetos, espada, arco, escudo, armadura, casco);
                        }
                        break;
                }
            } while (eleccion != 3); //Mientras no se escoja el 3, el menú seguirá apareciendo cuando sea indicado
            Console.WriteLine("¡Vuelva otra vez!");
            Console.ReadKey(); //Pausa
        }

        //Pantalla dónde se puede comprar distintos tipos de objetos a precios ya asignados, de tener el espacio y dinero suficiente
        static void TiendaCompra(ref int eleccion, ref int dinero, string nombre, string[] inventario, ref int objetos, int espada, int arco, int escudo, int armadura, int casco)
        {
            while (eleccion != 6 && objetos < inventario.Length) //Mientras no se escoja el 6 o se llegue al límite de capacidad, se pueden comprar todos los objetos que se puedan permitir
            {
                Console.Clear(); //Limpiar la pantalla
                //Llamar a la interfaz que informa sobre el dinero y los objetos poseídos
                HUD(ref dinero, inventario);
                Console.WriteLine(); //Salto de línea
                Console.WriteLine("¿Qué te interesa? Esto es lo que tengo:");
                //Se saca por pantalla el precio de compra, que fue asignado aleatoriamente para cada objeto
                Console.WriteLine("1. Espada    Precio: " + espada + "$");
                Console.WriteLine("2. Arco    Precio: " + arco + "$");
                Console.WriteLine("3. Escudo    Precio: " + escudo + "$");
                Console.WriteLine("4. Armadura    Precio: " + armadura + "$");
                Console.WriteLine("5. Casco    Precio: " + casco + "$");
                Console.WriteLine("6. Salir.");
                //Se evita que se responda con ninguna respuesta indeseada
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 6)
                {
                    Console.WriteLine("¿Qué se supone que significa eso?");
                }
                //El programa toma un camino dependiendo del número escogido
                switch (eleccion)
                {
                    case 1:
                        //Llamar a la función de compra, tomando el nombre y precio de la espada
                        Comprar(ref dinero, "Espada", inventario, ref objetos, espada);
                        break;
                    case 2:
                        //Llamar a la función de compra, tomando el nombre y precio del arco
                        Comprar(ref dinero, "Arco", inventario, ref objetos, arco);
                        break;
                    case 3:
                        //Llamar a la función de compra, tomando el nombre y precio del escudo
                        Comprar(ref dinero, "Escudo", inventario, ref objetos, escudo);
                        break;
                    case 4:
                        //Llamar a la función de compra, tomando el nombre y precio de la armadura
                        Comprar(ref dinero, "Armadura", inventario, ref objetos, armadura);
                        break;
                    case 5:
                        //Llamar a la función de compra, tomando el nombre y precio del casco
                        Comprar(ref dinero, "Casco", inventario, ref objetos, casco);
                        break;
                }
            }
        }

        //Función que lleva a cabo la compra de un objeto con un nombre y precio determinado
        static void Comprar(ref int dinero, string nombre, string[] inventario, ref int objetos, int precio)
        {
            //Se asegura de que el usuario tenga suficiente dinero para comprar el objeto en cuestión
            if (dinero < precio)
            {
                Console.WriteLine("¡Oye! Que no tienes dinero suficiente.");
                Console.ReadKey(); //Pausa
            }
            else
            {
                dinero -= precio; //Quita de la cantidad de dinero total el precio del objeto
                inventario[objetos] = nombre; //Registra el nombre del objeto en la lista del inventario
                objetos++; //La cantidad de objetos en el inventario aumenta en 1
                Console.WriteLine("¡Gracias por su compra!");
                Console.ReadKey(); //Pausa
            }
        }

        //Pantalla dónde se puede vender distintos tipos de objetos a la mitad de su precio de compra, de tener objetos en el espacio indicado
        static void TiendaVenta(ref int eleccion, ref int dinero, string nombre, string[] inventario, ref int objetos, int espada, int arco, int escudo, int armadura, int casco)
        {
            do
            {
                Console.Clear(); //Limpiar la pantalla
                //Llamar a la interfaz que informa sobre el dinero y los objetos poseídos
                HUD(ref dinero, inventario);
                Console.WriteLine("6. Salir.");
                Console.WriteLine(); //Salto de línea
                Console.WriteLine("¿Qué quieres vender? Esto es lo que te ofrezco:");
                //Se saca por pantalla el precio de venta, que es la mitad del de compra
                Console.WriteLine("Espada    Oferta: " + espada / 2 + "$");
                Console.WriteLine("Arco    Oferta: " + arco / 2 + "$");
                Console.WriteLine("Escudo    Oferta: " + escudo / 2 + "$");
                Console.WriteLine("Armadura    Oferta: " + armadura / 2 + "$");
                Console.WriteLine("Casco    Oferta: " + casco / 2 + "$");
                //Se evita que se responda con ninguna respuesta indeseada
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 6)
                {
                    Console.WriteLine("¿Qué se supone que significa eso?");
                }
                //Se asegura de que no se venda ningún objeto de escoger el 6 o no tener ningún objeto en el inventario
                if (eleccion != 6 && objetos != 0)
                {
                    //Llamar a la función de compra, tomando el nombre del objeto elegido y precio de todos los objetos
                    Vender(eleccion, ref dinero, inventario[eleccion - 1], inventario, ref objetos, espada, arco, escudo, armadura, casco);
                }
            } while (eleccion != 6 && objetos != 0); //Mientras no se escoja el 6 o no se tenga ningún objeto en el inventario, se pueden vender todos los objetos que uno tenga
        }

        //Función que lleva a cabo la venta de un objeto con un nombre y precio determinado
        static void Vender(int eleccion, ref int dinero, string nombre, string[] inventario, ref int objetos, int espada, int arco, int escudo, int armadura, int casco)
        {
            int precio = 0; //Asigna un valor inicial a la variable local precio
            //Se asegura de que el usuario tenga un objeto en el espacio en cuestión
            if (inventario[eleccion - 1] == "")
            {
                Console.WriteLine("¡Oye! Que no tienes ningún objeto en ese espacio.");
                Console.ReadKey(); //Pausa
            }
            else
            {
                //El programa toma un camino dependiendo del nombre del objeto escogido
                switch (nombre)
                {
                    case "Espada":
                        //Le asigna a la variable local el precio de venta de la espada
                        precio = espada / 2;
                        break;
                    case "Arco":
                        //Le asigna a la variable local el precio de venta del arco
                        precio = arco / 2;
                        break;
                    case "Escudo":
                        //Le asigna a la variable local el precio de venta del escudo
                        precio = escudo / 2;
                        break;
                    case "Armadura":
                        //Le asigna a la variable local el precio de venta de la armadura
                        precio = armadura / 2;
                        break;
                    case "Casco":
                        //Le asigna a la variable local el precio de venta del casco
                        precio = casco / 2;
                        break;
                }
                dinero += precio; //Añade a la cantidad de dinero total el precio del objeto
                inventario[eleccion - 1] = ""; //Borra el nombre del objeto de la lista del inventario
                objetos--; //La cantidad de objetos en el inventario disminuye por 1
                //Ordena la lista de objetos
                for (int i = 0; i < inventario.Length - 1; i++)
                {
                    //Se asegura de que el espacio esté vacío
                    if (inventario[i] == "")
                    {
                        inventario[i] = inventario[i + 1]; //Mueve el nombre del espacio posterior al actual
                        inventario[i + 1] = ""; //Borra el nombre ya movido de la lista
                    }
                }
                Console.WriteLine("Lo pondré a buen recaudo.");
                Console.ReadKey(); //Pausa
            }
        }
    }
}
