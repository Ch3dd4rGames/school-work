using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Estudiante
    {
        static string Curso = "1º de Videojuegos";
        public readonly string Nombre, Apellidos;
        private double Calificacion;
        static double SumaNotas = 0;
        public static double NotaMedia = -1;
        static int TotalEstudiantes = 0;

        public Estudiante()
        {
            Console.WriteLine("Inserta el nombre del estudiante: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Inserta el apellido del estudiante: ");
            Apellidos = Console.ReadLine();
            Calificacion = -1; //Valor por defecto, significa que no has sido

            TotalEstudiantes++;
        }

        public void Calificar(double nota)
        {
            if (Calificacion == -1 && nota >= 0 && nota <= 10)
            {
                Calificacion = nota;
                SumaNotas += Calificacion;
                NotaMedia = SumaNotas / TotalEstudiantes;
            }
            else
                Console.WriteLine("No se ha podido calificar al alumno.");
        }

        public static void MostrarNotaMedia()
        {
            if (NotaMedia != -1)
                Console.WriteLine("La nota media de la clase es " + NotaMedia + ".");
            else
                Console.WriteLine("No se puede mostrar la nota media.");
        }

        public void MostrarDatosEstudiante()
        {
            Console.WriteLine("Estudiante {0} {1}", Nombre, Apellidos);
            if (Calificacion == -1)
                Console.WriteLine("Este estudiante aun no ha sido calificado.");
            else
            {
                Console.WriteLine("Calificación: {0}", Calificacion);
                MostrarNotaMedia();
                if (Calificacion > NotaMedia)
                    Console.WriteLine("Este estudiante tiene una nota por encima de la media.");
                else if (Calificacion < NotaMedia)
                    Console.WriteLine("Este estudiante tiene una nota por debajo de la media.");
                else
                    Console.WriteLine("Este estudiante tiene una nota que es igual a la media.");
            }
        }
    }
}
