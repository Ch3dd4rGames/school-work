// ConsoleApplication8.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;

/*
int main()
{
    int* ptr = new int[1000]; //Reserva memoria para guardar 1000 enteros
    *ptr = 4; //Inicializa el primer elemento
    *(ptr + 1) = 10; //Inicializa el segundo elemento
    delete[]ptr; //Libera la memoria
}
*/

struct TClientes
{
    string codigo, nombre;
};
struct TProveedores
{
    string codigo, nombre;
};
TClientes* ReservarMemoria(TClientes *&ptr);
TClientes** InicializarNULL();

int main()
{
    double* ptrDoub = new double;
    int* ptrInt = new int;
    TClientes* ptrClie = new TClientes;
    TProveedores* ptrProv = new TProveedores;
    TClientes* arrClie1 = new TClientes[100];
    TClientes* arrClie2 = ReservarMemoria(arrClie1);
    TClientes** arrClie3;
    arrClie3 = new TClientes * [100];
    for (int i = 0; i < 100; i++)
    {
        *(arrClie3 + i) = NULL;
    }
    TClientes **arrClie4 = InicializarNULL();
    TProveedores** arrProv;
    arrProv = new TProveedores * [120];
    for (int i = 0; i < 120; i++)
    {
        *(arrProv + i) = new TProveedores;
    }
    delete[] arrClie2;
    DestruirArray(arrClie2);
    delete[] arrProv;
    DestruirArray(arrProv);
}

TClientes* ReservarMemoria(TClientes* &ptr)
{
    ptr = new TClientes[100];
    return ptr;
}

TClientes** InicializarNULL()
{
    TClientes **ptr = new TClientes * [100];
    for (int i = 0; i < 100; i++)
    {
        *(ptr + i) = NULL;
    }
    return ptr;
}

void DestruirArray(TClientes* arrClie)
{
    delete[] arrClie;
}

void DestruirArray(TProveedores** arrProv)
{
    delete[] arrProv;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
