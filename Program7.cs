using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinero = 500, pociones = 3;
            int[] inventario = { 0, 0, 0 };

            while (true)
            {
                Tienda(ref dinero, inventario);
                LineaSeparadora('$', 120);
                Console.ReadLine();
            }
        }

        static void ComprarPocion(ref int dinero, ref int pociones)
        {
            Console.WriteLine("¿Cuántas pociones quieres (coste 50mo)?");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int coste = cantidad * 50;
            if (dineroInt = coste)
            {

            }
        }

        static void Tienda(ref int dinero, int[] inventario)
        {

        }

        static void GenerarFicha(out int fuerza, out int destreza, out int carisma)
        {

        }

        static void TextoEnmarcado(string txt)
        {
            LineaSeparadora();
            Console.WriteLine(txt);
            LineaSeparadora();
        }

        static void LineaSeparadora()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            LineaSeparadora('*', 80);
            LineaSeparadora('-', 100);
            Console.ResetColor();
        }

        static void LineaSeparadora(char letra, int longitud)
        {
            for(int i = 0; i < longitud; i++)
            {
                Console.Write(letra);
            }
            Console.WriteLine();
        }

            //Console.WriteLine("Dame 2 números: ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Minimo(numero1, numero2);
            //Console.WriteLine("El mínimo de ambos es " + numero3);
            //LineaSeparadora('.', 120);
            //Console.WriteLine("El mínimo de ambos es " + Minimo(numero1, numero2));
            
            //TextoEnmarcado("PIENSA Y ADIVINA");
            //Console.WriteLine("\n\n\n");
            //LineaSeparadora('a', 50);
            //Console.WriteLine("FIN");
    }
}
