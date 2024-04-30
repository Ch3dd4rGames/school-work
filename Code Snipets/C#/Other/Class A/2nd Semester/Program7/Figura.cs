using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Figura
    {
        public const int MAX_FALLOS = 6;

        public static void PintarFigura(int numFallos)
        {
            switch (numFallos)
            {
                case 0:
                    Console.WriteLine("+------+");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("+--------------");
                    break;
                case 1:
                    Console.WriteLine("+------+");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      #");
                    Console.WriteLine("|     (_)");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("+--------------");
                    break;
                case 2:
                    Console.WriteLine("+------+");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      #");
                    Console.WriteLine("|     (_)");
                    Console.WriteLine("|     [ ]");
                    Console.WriteLine("|     [_]");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("+--------------");
                    break;
                case 3:
                    Console.WriteLine("+------+");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      #");
                    Console.WriteLine("|     (_)");
                    Console.WriteLine("|  x--[ ]");
                    Console.WriteLine("|     [_]");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("+--------------");
                    break;
                case 4:
                    Console.WriteLine("+------+");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      #");
                    Console.WriteLine("|     (_)");
                    Console.WriteLine("|  x--[ ]--x");
                    Console.WriteLine("|     [_]");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("+--------------");
                    break;
                case 5:
                    Console.WriteLine("+------+");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      #");
                    Console.WriteLine("|     (_)");
                    Console.WriteLine("|  x--[ ]--x");
                    Console.WriteLine("|     [_]");
                    Console.WriteLine("|    _|");
                    Console.WriteLine("+--------------");
                    break;
                case 6:
                    Console.WriteLine("+------+");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      #");
                    Console.WriteLine("|     (_)");
                    Console.WriteLine("|  x--[ ]--x");
                    Console.WriteLine("|     [_]");
                    Console.WriteLine("|    _| |_");
                    Console.WriteLine("+--------------");
                    Console.WriteLine("Has perdido estrepitosamente.");
                    break;
            }
        }
    }
}

