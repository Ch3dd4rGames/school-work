// ConsoleApplication20.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
#include <vector>
using namespace std;

template <typename T>
T suma(vector<T> v);

int main()
{
    //suma("fefge0", 43);
    vector<int> v = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int resultado = suma(v);
    cout << resultado << endl;
}

template <typename T>
T suma(vector<T> v)
{
    T suma = 0;
    for (size_t i = 0; i < v.size(); ++i)
        suma += v[i];
    return suma;
}

/*
int suma(int a, char b)
{
    return a + b;
}

template <typename T1, typename T2>
void suma(T1 a, T2 b)
{
    return a + b;
}

template <typename T1>
void suma(T1 a, T1 b)
{
    return a + b;
}

template <typename T>
void show(T* begin, T* end, std::size_t t)
{
    std::cout << '{';
    for (; begin != end; ++begin)
        std::cout << '\'' << *begin << '\'' << (begin != end - 1 ? ",")
        std::cout << "}remain " << t << " elements" << std::endl;
}

template <typename T>
void intercambiar(T a, T b)
{
    T c = a;
    a = b;
    b = c;
}
*/

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
