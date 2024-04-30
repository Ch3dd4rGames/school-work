// ConsoleApplication3.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;

/*
void remove_compact(size_t i, char arr[], size_t arr_size)
{
    for (i; i < arr_size; i++)
    {
        if (i == arr_size - 1)
            arr[i] = 0;
        else
            arr[i] = arr[i + 1];
    }            
}

//Debe eliminar del array el elemento en la posición 'i', desplazando el resto de elementos una posición a la izquierda para no dejar un hueco

int main()
{
    char miarray[6] = { '*', '¡', 'j', '-', '<', '3' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    size_t tam = sizeof(miarray) / sizeof(miarray[0]);
    size_t decision;
    cout << "El array de caracteres 'arr' tiene los siguientes elementos: { ";
    for (size_t i = 0; i < tam; i++)
    {
        cout << "'" << miarray[i] << "'";
        if (i == tam - 1)
            cout << " }" << endl;
        else
            cout << ", ";
    }
    do
    {
        cout << "Escoge qué posición quieres eliminar (0-" << tam - 1 << "): " << endl;
        cin >> decision;
        if (decision < 0 || decision > tam - 1)
        cout << "Por favor, escoge una posición valida" << endl;
    } while (decision < 0 || decision > tam - 1);
    remove_compact(decision, miarray, tam);
    cout << "Tras borrar la posición " << decision << " el array de caracteres 'arr' ahora tiene los siguientes elementos : { ";
    for (size_t i = 0; i < tam; i++)
    {
        cout << "'" << miarray[i] << "'";
        if (i == tam - 1)
            cout << " }" << endl;
        else
            cout << ", ";
    }
}
*/

/*
void add_compact(size_t i, char c, char arr[], size_t arr_size)
{
    for (size_t j = arr_size - 1; j > i; j--)
    {
        arr[j] = arr[j - 1];
    }
    arr[i] = c;
}

//Añade en la posición 'i' del array el caracter 'c', desplazando los elementos una posición a la derecha para hacer hueco al nuevo elemento

int main()
{
    char miarray[6] = { '*', '¡', 'j', '-', '<', '3' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    size_t tam = sizeof(miarray) / sizeof(miarray[0]);
    size_t decision;
    char caracter;
    cout << "El array de caracteres 'arr' tiene los siguientes elementos: { ";
    for (size_t i = 0; i < tam; i++)
    {
        cout << "'" << miarray[i] << "'";
        if (i == tam - 1)
            cout << " }" << endl;
        else
            cout << ", ";
    }
    cout << "Inserta un caracter: "<< endl;
    cin >> caracter;
    do
    {
        cout << "Escoge en qué posición del array lo quieres meter (0-" << tam - 1 << "): " << endl;
        cin >> decision;
        if (decision < 0 || decision > tam - 1)
            cout << "Por favor, escoge una posición valida" << endl;
    } while (decision < 0 || decision > tam - 1);
    add_compact(decision, caracter, miarray, tam);
    cout << "Tras añadir el caracter '" << caracter << "' en la posición " << decision << ", el array de caracteres 'arr' ahora tiene los siguientes elementos : { ";
    for (size_t i = 0; i < tam; i++)
    {
        cout << "'" << miarray[i] << "'";
        if (i == tam - 1)
            cout << " }" << endl;
        else
            cout << ", ";
    }
}
*/

void filter_compact(int elem, int arr[], size_t arr_size)
{
    for (int i = 0; i <= arr_size; i++)
    {
        if (arr[i] == elem)
        {
            for (int j = i; j < arr_size; j++)
            {
                if (j == arr_size - 1)
                    arr[j] = 0;
                else
                    arr[j] = arr[j + 1];
            }
        }
    }
}

//Debe modificar el array eliminando las ocurrencias del elemento 'elem', y compactar el array eliminando los huecos de forma que todos los elementos estén agrupados consecutivamente de izquierda a derecha

int main()
{
    int miarray[6] = { 4, 7, 2, 1, 4, 9 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    size_t tam = sizeof(miarray) / sizeof(miarray[0]);
    int elemento;
    cout << "El array de enteros 'arr' tiene los siguientes elementos: { ";
    for (size_t i = 0; i < tam; i++)
    {
        cout << miarray[i];
        if (i == tam - 1)
            cout << " }" << endl;
        else
            cout << ", ";
    }
    cout << "Inserte un número entero: " << endl;
    cin >> elemento;
    filter_compact(elemento, miarray, tam);
    cout << "Tras borrar las ocurrencias de " << elemento << " en el array de enteros 'arr', ahora tiene los siguientes elementos : { ";
    for (size_t i = 0; i < tam; i++)
    {
        cout << miarray[i];
        if (i == tam - 1)
            cout << " }" << endl;
        else
            cout << ", ";
    }
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
