// ConsoleApplication18.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <stdlib.h>
#include <time.h>
#include <iostream>
#include "Gerente.h"
using namespace std;

int main()
{
    Empleado* empleados[10];
    *(empleados) = new Empleado("Carlos", 3572, 1500, 0);
    int longitud = 1, random;
    do
    {
        cout << "¿Cuántos empleados quieres ver? (1-10)" << endl;
        cin >> longitud;
        if (longitud < 1 || longitud > 10)
            cout << "No has metido una cantidad válida." << endl;
    } while (longitud < 1 || longitud > 10);
    srand(time(NULL));
    for (int i = 0; i < longitud; i++)
    {
        random = rand() % 2;
        if (random == 0)
            *(empleados + i) = 
    }

    /*
    Gerente obj1;
    obj1.imprimir();
    Empleado* p_obj1 = &obj1;
    p_obj1->imprimir();
    return 0;
    */
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
