// ConsoleApplication5.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
#include <vector>
using namespace std;

vector<int> comunes(vector<int> v1, vector<int> v2) 
{
    vector<int> v3;
    vector<int> numComunes;
    bool rep = false;
    for (int i = 0; i < size(v1); i++) 
    {
        for (int j = 0; j < size(v2); j++) 
        {
            if (v1[i] == v2[j]) 
            {
                for (int k = 0; k < size(numComunes) && !rep; k++) 
                {
                    if (numComunes[k] == v1[i]) 
                        rep = true;
                    else
                        rep = false;
                }
                if (!rep) 
                {
                    v3.push_back(v1[i]);
                    numComunes.push_back(v1[i]);
                }
            }
        }
        rep = false;
    }
    return v3;
}

//Debe devolver un vector con los elementos en común de los vectores 'v1' y 'v2' sin incluir elementos repetidos

int main()
{
    vector <int> v1 = { 1, 3, 2, 1 };
    vector <int> v2 = { 1, 3, 4, 1 };
    vector <int> v3 = comunes(v1, v2);
    for (const int& i : v3)
        cout << i << "  ";
}

/*
int main()
{
    int* mipuntero; //Declarar variable puntero
    int edad = 18; //Declarar e inicializar variable entera
    cout << "Edad: " << edad << endl; //edad = 18
    mipuntero = &edad; //Asignar la dirección de la variable edad al puntero
    edad = *mipuntero + 1;
    cout << "Edad: " << edad << endl; //edad = 19
}
*/

/*
int main()
{
    //Declaración variables
    int lapices, plumas, total;
    //Declaración variable referencia
    //Crea un duplicado de la variable original
    //Todos los cambios que se realicen sobre su referencias se aplican a la variable original
    int& referencia_lapices = lapices;
    int& referencia_plumas = plumas;
    int& referencia_total = total;
    //Declaración punteros
    int* puntero_lapices = &lapices;
    int* puntero_plumas = &plumas;
    int* puntero_total = &total;
    //Inicialización de las variables a través de sus referencias
    referencia_lapices = 5; //Lápices = 5
    referencia_plumas = 2; //Plumas = 2
    referencia_total = referencia_lapices + referencia_plumas; //Total = 7
    *puntero_lapices = 8; //Lápices = 8
    *puntero_plumas = 3; //Plumas = 3
    *puntero_total = *puntero_lapices + *puntero_plumas; //Total = 11
}
*/

/*
int main()
{
    int array[5] = { 1, 2, 3, 4, 5 }; //Array de enteros
    int* ptr; //Puntero a enteros
    ptr = array; //array -- Puntero al primer elemento del array --> array = &array[0]
    //Modificar el primer elemento del array
    array[0] = 6;
    *ptr = 8;
    //Modificar el segundo elemento del array
    array[1] = 10;
    *(ptr + 1) = 14;
    //Recorrer array a través de índices
    for (int i = 0; i < 5; i++)
    {
        cout << "Elemento número " << array[i] << endl;
        cout << "Elemento número " << *(ptr + i) << endl;
    }
    ptr++; //Mover el puntero a la siguiente dirección de memoria
    int* ptr_inicial = &array[0];
    int* ptr_final = &array[4];
    int longitud = ptr_final - ptr_inicial; //Número de posiciones de memoria entre un puntero y otro
    int a = *ptr_final - *ptr_inicial; //Diferencia de los valores guardados en las direcciones de memoria que se están apuntando
}
*/

/*
int main()
{
    //Intercambiar los valores de los siguientes arrays:
    int array1[4] = { 1, 4, 8, 0 };
    int array2[4] = { 2, 3, 5, 6 };
    //Sin punteros
    int almacenador;
    for (size_t i = 0; i < 5; i++)
    {
        almacenador = array1[i];
        array1[i] = array2[i];
        array2[i] = almacenador;
    }
    //Con punteros
    int* ptr1 = array1;
    int* ptr2 = array2;
    int* ptrtemp;
    ptrtemp = ptr1;
    ptr1 = ptr2;
    ptr2 = ptrtemp;
}
*/

/*
int main()
{
    int array[10] = { 21, 56, 34, 13, 62, 29, 7, 88, 45, 100 };
    int* ptr_inicial = &array[0];
    int* ptr_final = &array[9];
    size_t tam = ptr_final - ptr_inicial;
    int alm = *ptr_inicial;
    for (size_t i = 0; i <= tam; i++)
    {
        if (*(ptr_inicial + i) % 2 == 0)
            cout << "El elemento " << *(ptr_inicial + i) << " en la posición " << i << " del array es PAR, y su posición de memoria es " << ptr_inicial + i << endl;
        if (*(ptr_inicial + i) < alm)
            alm = *(ptr_inicial + i);
    }
    cout << endl;
    cout << "El elemento " << alm << " es el MENOR del array, y su posición de memoria es " << &alm << endl;
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
