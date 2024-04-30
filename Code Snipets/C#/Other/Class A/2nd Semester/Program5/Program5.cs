using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Estudiante[] lista_estudiantes = new Estudiante[3];
            int nota;

            for (int i = 0; i < lista_estudiantes.Length; i++)
            {
                lista_estudiantes[i] = new Estudiante();
                nota = r.Next(0, 11);
                lista_estudiantes[i].Calificar(nota);
                Console.WriteLine("La nota de {0} {1} es de {2}", lista_estudiantes[i].Nombre, lista_estudiantes[i].Apellidos, nota);
            }

            Console.WriteLine("Hello World!");
            Estudiante.MostrarNotaMedia();
        }
    }
}
