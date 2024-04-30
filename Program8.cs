using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int iEscritura = 0;
            int num = -1;

            Console.WriteLine("LISTA NÚMEROS");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Indice " + i + " --> " + numeros[i]);
            }
            
            while(num != 0)
            {
                Console.WriteLine("Escribe un número (0 para salir)");
                num = Convert.ToInt32(Console.ReadLine());
                numeros[iEscritura] = num;
                iEscritura++;
            }

            Console.WriteLine("LISTA NÚMEROS");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Indice " + i + " --> " + numeros[i]);
            }
        }

        static void Cuadrados(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = valores[i] * valores[i];
            }
        }
    }
}
