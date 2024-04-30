using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class PalabraOculta
    {
        public int numAciertos = 0;
        public char[] palabra_char, letras;

        public PalabraOculta(string palabra_adivinar)
        {
            palabra_char = new char[palabra_adivinar.Length];
            letras = palabra_adivinar.ToCharArray();
            for (int i = 0; i < palabra_adivinar.Length; i++)
            {
                palabra_char[i] = '_';
            }
        }

        public void MostrarResultados(char adivinanza, string palabra_adivinar)
        {
            for (int i = 0; i < palabra_adivinar.Length; i++)
            {
                if (adivinanza == letras[i])
                {
                    palabra_char[i] = adivinanza;
                    numAciertos++;
                }
                else if (palabra_char[i] != '_')
                {
                    numAciertos++;
                }
                Console.Write(palabra_char[i] + " ");
            }
            Console.WriteLine("\n");          
        }
    }
}