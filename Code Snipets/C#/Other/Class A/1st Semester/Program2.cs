using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro e inicio las variables.
            int a, b, suma, resta, producto, cociente, resto;

            //realizo las operaciones.
            a = 3;
            b = 4;
            suma = a + b;
            resta = a - b;
            producto = a * b;
            cociente = a / b;
            resto = a % b;

            //saco por pantalla los resultados.
            Console.WriteLine("La suma de " + a + " + " + b + " es " + suma);
            Console.WriteLine("La resta de " + a + " - " + b + " es " + resta);
            Console.WriteLine("El producto de " + a + " * " + b + " es " + producto);
            Console.WriteLine("El cociente de " + a + " / " + b + " es " + cociente);
            Console.WriteLine("El resto de " + a + " % " + b + " es " + resto);
        }
    }
}
