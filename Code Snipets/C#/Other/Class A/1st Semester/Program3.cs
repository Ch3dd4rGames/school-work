using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, suma, resta, producto, cociente, resto, decision;

            Console.WriteLine("Escribe el primer número:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número:");
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            resta = a - b;
            producto = a * b;
            cociente = a / b;
            resto = a % b;

            Console.WriteLine("Selecciona operación:");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. RESTA");
            Console.WriteLine("3. PRODUCTO");
            Console.WriteLine("4. COCIENTE");
            Console.WriteLine("5. RESTO");
            decision = Convert.ToInt32(Console.ReadLine());

            if (decision >= 1 && decision <= 5)
            {
                if (decision == 1)
                {
                    Console.WriteLine("La suma de " + a + " + " + b + " es " + suma);
                }
                if (decision == 2)
                {
                    Console.WriteLine("La resta de " + a + " - " + b + " es " + resta);
                }
                if (decision == 3)
                {
                    Console.WriteLine("El producto de " + a + " * " + b + " es " + producto);
                }
                if (decision == 4)
                {
                    Console.WriteLine("El cociente de " + a + " / " + b + " es " + cociente);
                }
                if (decision == 5)
                {
                    Console.WriteLine("El resto de " + a + " % " + b + " es " + resto);
                }
            }
            else
            {
                Console.WriteLine("Esa operación no existe");
            }







        }
    }
}
