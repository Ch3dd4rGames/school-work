// ConsoleApplication14.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
#include "Punto2D.h"
#include "Rectangulo.h"
using namespace std;

int main()
{
    /*
    Punto2D punto; //Constructor por defecto sin argumentos
    Punto2D punto1(3, 7); //Constructor con argumentos
    Punto2D* punto2 = new Punto2D(4, 5); //Constructor con argumentos, donde el objeto se declara en memoria dinámica (new). Cuando se termine de usar el objeto punto2, es necesario destruirlo
    */
    Rectangulo rect1(3, 6);
    Rectangulo rect2 = rect1;
    int a = 1;
    int b = a;
    int c = a + b;
    Rectangulo rect3 = rect1 + rect2;
    cout << "Lado 1: " << rect3.getlado1() << endl;
    cout << "Lado 2: " << rect3.getlado2() << endl;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
