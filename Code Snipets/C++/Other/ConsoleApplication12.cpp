// ConsoleApplication13.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
using namespace std;

struct Nodo
{
    int dato;
    Nodo* siguiente;
};

void agregarPila(Nodo*& pila, int n);
void sacarPila(Nodo*& pila, int& n);
void mostrarPila(Nodo* pila);
Nodo* getSiguiente(Nodo* nodo);

int main()
{
    Nodo* cimaPila = new Nodo{ 6, NULL };
    mostrarPila(cimaPila);
    agregarPila(cimaPila, 7);
    mostrarPila(cimaPila);
    int dato;
    sacarPila(cimaPila, dato);
    mostrarPila(cimaPila);
    return 0;
}

void agregarPila(Nodo*& pila, int n)
{
    Nodo* nuevo_nodo = new Nodo();
    nuevo_nodo -> dato = n;
    nuevo_nodo -> siguiente = pila;
    pila = nuevo_nodo;
}

void sacarPila(Nodo*& pila, int& n)
{
    Nodo* aux = pila;
    n = aux -> dato;
    pila = aux -> siguiente;
    delete aux;
}

void mostrarPila(Nodo* cimaPila)
{
    do
    {
        cout << "Dato" << cimaPila -> dato << endl;
        cimaPila = getSiguiente(cimaPila);
    } while (cimaPila != NULL);
}

Nodo* getSiguiente(Nodo* nodo)
{
    return nodo -> siguiente;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
