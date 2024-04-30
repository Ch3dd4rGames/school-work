using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Coche
    {
        //Propiedades o atributos
        int CombustibleMaximo;
        int Combustible; //Actual
        int VelocidadMaxima;
        int Velocidad;
        string Color;
        string Marca;

        string[] PosiblesMarcas = {"Renault", "Volvo", "Seat", "Opel", "Audi", "Mercedes"};
        string[] PosiblesColores = {"rojo", "amarillo", "verde", "azul", "blanco", "negro"};

        //Método Constructor
        public Coche (int vmax, int cmax, int vel, int com, string color, string marca)
        {
            Console.WriteLine("\nCREANDO UN NUEVO COCHE");
            Marca = marca;
            Color = color;

            if (vmax < 0)
                VelocidadMaxima = 0;
            else
                VelocidadMaxima = vmax;

            if (vel > VelocidadMaxima)
                Velocidad = VelocidadMaxima;
            else if (vel < 0)
                Velocidad = 0;
            else
                Velocidad = vel;

            if (cmax < 0)
                CombustibleMaximo = 0;
            else
                CombustibleMaximo = cmax;


            if (com > CombustibleMaximo)
                Combustible = CombustibleMaximo;
            else if (com < 0)
                Combustible = 0;
            else
                Combustible = com;

            Console.WriteLine("COCHE CREADO");
            MostrarCoche();
        }

        public Coche(int vmax, int cmax)
        {
            Random r = new Random();
            int i;
            Console.WriteLine("\nCREANDO UN NUEVO COCHE");
            i = r.Next(0, PosiblesMarcas.Length);
            Marca = PosiblesMarcas[i];

            i = r.Next(0, PosiblesColores.Length);
            Color = PosiblesColores[i];

            VelocidadMaxima = vmax;
            Velocidad = r.Next(0, VelocidadMaxima + 1);

            CombustibleMaximo = cmax;
            Combustible = r.Next(0, CombustibleMaximo + 1);

            Console.WriteLine("COCHE CREADO");
            MostrarCoche();
        }

        public Coche()
        {
            Console.WriteLine("\nCREANDO UN NUEVO COCHE");
            Console.Write("\tInserta la marca: ");
            Marca = Console.ReadLine();

            Console.Write("\tInserta el color: ");
            Color = Console.ReadLine();

            Console.Write("\tInserta la velocidad máxima: ");
            while (!int.TryParse(Console.ReadLine(), out VelocidadMaxima) || VelocidadMaxima < 0)
            {
                Console.Write("\tError, debes insertar un número entero mayor o igual a 0. ");
                Console.Write("\tInserta la velocidad máxima: ");
            }

            Console.Write("\tInserta la velocidad actual: ");
            while (!int.TryParse(Console.ReadLine(), out Velocidad) || Velocidad < 0 || Velocidad > VelocidadMaxima)
            {
                Console.Write("\tError, debes insertar un número entre 0 y {0}. ", VelocidadMaxima);
                Console.Write("\tInserta la velocidad actual: ");
            }

            Console.Write("\tInserta el combustible máximo: ");
            while (!int.TryParse(Console.ReadLine(), out CombustibleMaximo) || CombustibleMaximo < 0)
            {
                Console.Write("\tError, debes insertar un número entero mayor o igual a 0. ");
                Console.Write("\tInserta el combustible máximo: ");
            }

            Console.Write("\tInserta el combustible actual: ");
            while (!int.TryParse(Console.ReadLine(), out Combustible) || Combustible < 0 || Combustible > CombustibleMaximo)
            {
                Console.Write("\tError, debes insertar un número entre 0 y {0}. ", CombustibleMaximo);
                Console.Write("\tInserta el combustible máximo: ");
            }
        }

        //Métodos
        public void MostrarCoche()
        {
            Console.WriteLine("Características del {1} de color {0}:", Color, Marca);
            Console.Write("\tCombustible máximo: {0} litros", CombustibleMaximo);
            Console.Write("\tCombustible actual: {0} litros", Combustible);
            Console.Write("\tVelocidad máxima: {0} km/h", VelocidadMaxima);
            Console.Write("\tVelocidad actual: {0} km/h", Velocidad);
            Console.WriteLine(); //SALTO DE LÍNEA
        }

        private void GastarCombustible(int litros_gastados)
        {
            Combustible -= litros_gastados;
            if (Combustible < 0)
                Combustible = 0;
        }

        public void Acelerar(int aceleracion)
        {
            Console.WriteLine("ACELERANDO el {1} de color {0}:", Color, Marca);
            Console.Write("\tVelocidad actual antes de acelerar: {0} km/h", Velocidad);
            if (Velocidad + aceleracion <= VelocidadMaxima)
            {
                Velocidad += aceleracion;
                GastarCombustible(aceleracion);
            }
            else
                Velocidad = VelocidadMaxima;

            Console.Write("\tVelocidad actual después de acelerar: {0} km/h", Velocidad);
        }

        public void Frenar(int frenado)
        {
            Console.WriteLine("FRENANDO el {1} de color {0}:", Color, Marca);
            Console.Write("\tVelocidad actual antes de frenar: {0} km/h", Velocidad);
            Velocidad -= frenado;
            if (Velocidad < 0)
                Velocidad = 0;

            Console.Write("\tVelocidad actual después de frenar: {0} km/h", Velocidad);
        }
    }
}
