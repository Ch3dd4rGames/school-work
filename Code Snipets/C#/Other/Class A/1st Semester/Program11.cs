using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;//opción que escoge el usuario en el menú
            double a, b, operación;

            do
            {
                Console.WriteLine("\tPulsa 1 para sumarlos");
                Console.WriteLine("\tPulsa 2 para restarlos");
                Console.WriteLine("\tPulsa 3 para multiplicarlos");
                Console.WriteLine("\tPulsa 4 para dividirlos");
                Console.WriteLine("\tPulsa 5 para salir del programa");
                Console.Write("\tSelecciona una opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                   if (opc > 5 || opc < 1)
                   {
                    Console.WriteLine("Error, pulsa una opción entre 1 y 5");
                }
            } while (opc > 5 || opc < 1);

                Console.WriteLine("Escribe el primer número:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe el segundo número:");
                b = Convert.ToDouble(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    //suma
                    operación = a + b;
                    Console.WriteLine("La suma de " + a + " + " + b + " es " + operación);
                    break;
                case 2:
                    //resta
                    operación = a - b;
                    Console.WriteLine("La resta de " + a + " - " + b + " es " + operación);
                    break;
                case 3:
                    //multiplicación
                    operación = a * b;
                    Console.WriteLine("La multiplicación de " + a + " * " + b + " es " + operación);
                    break;
                case 4:
                    //división
                    operación = a / b;
                    Console.WriteLine("La división de " + a + " / " + b + " es " + operación);
                    break;
            }

            Console.WriteLine("\nPulsa una tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine("\nFIN DEL PROGRAMA");
        }
    }
}
