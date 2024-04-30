// ConsoleApplication9.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include<stdlib.h>
#include<time.h>
using namespace std;

/*
int main()
{
    int* ptr1;
    int* ptr2;
    int a = 9;
    ptr1 = &a;
    ptr2 = NULL;
    ptr2 = ptr1;
    // Formas de acceder a la variable a y modificar su valor
    // 1ª Opción
    a = 3;
    // 2ª Opción
    *ptr1 = 10;
    // 3ª Opción
    *ptr2 = 1;
    // Comparar si apuntan a la misma posición de memoria
    // Es decir que guardan la misma dirección
    if (ptr1 == ptr2)
        cout << "Apuntan a la misma dirección" << endl;
    else
        cout << "Apuntan a distintas direcciones" << endl;

    // Comparar el valor de la variable a la que están apuntando
    if (*ptr1 == *ptr2)
        cout << "La variable a la que apuntan tiene el mismo valor" << endl;
    else
        cout << "La variable a la que apuntan no tiene el mismo valor" << endl;

    // Crear matriz
    int** matriz;
    matriz = new int* [6];
    for (int i = 0; i < 6; i++)
        matriz[i] = new int[4];

    // Dar valores a la matriz e imprima por pantalla
    // Con índices
    for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 4; j++) {
            matriz[i][j] = i + j;
            cout << matriz[i][j] << " ";
        }
        cout << endl;
    }
    cout << endl;

    int** matriz1;
    matriz1 = new int* [6];
    for (int i = 0; i < 6; i++)
        matriz1[i] = new int[4];

    // Dar valores a la matriz e imprima por pantalla
    // Con aritmética de punteros
    for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 4; j++) {
            *(*(matriz1 + i) + j) = i + j;
            cout << *(*(matriz1 + i) + j) << "  ";
        }
        cout << endl;
    }
    // Eliminar matriz
    for (int i = 0; i < 6; i++)
        delete matriz[i];
    delete[] matriz;
}
*/

int** CrearMatriz()
{
    int** matriz = new int* [6];
    for (int i = 0; i < 6; i++)
    {
        matriz[i] = new int[4];
    }
    return matriz;
}

void AsignarValores(int** matriz)
{
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 4; j++)
            *(*(matriz + i) + j) = rand()%10;
    }
}

void ImprimirMatriz(int** matriz)
{
    for (int i = 0; i < 6; i++)
    {
        cout << "{ ";
        for (int j = 0; j < 4; j++)
        {
            cout << *(*(matriz + i) + j);
            if (j < 3)
                cout << ", ";
        }
        cout << " }" << endl;
    }
}

int** SumarMatrices(int** matriz1, int** matriz2)
{
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 4; j++)
            *(*(matriz1 + i) + j) += *(*(matriz2 + i) + j);
    }
    return matriz1;
}

void EliminarMatriz(int** matriz)
{
    for (int i = 0; i < 6; i++)
        delete matriz[i];
    delete[] matriz;
}

int main()
{
    //Crear matrices
    int** m1;
    int** m2;
    m1 = CrearMatriz();
    m2 = CrearMatriz();

    //Dar valores a las matrices
    srand(time(NULL));
    AsignarValores(m1);
    AsignarValores(m2);

    //Imprimir las matrices por pantalla
    ImprimirMatriz(m1);
    cout << endl;
    ImprimirMatriz(m2);
    cout << endl;
    cout << endl;
    cout << endl;

    //Crear una función que sume dos matrices
    int** sumaMatrices;
    sumaMatrices = SumarMatrices(m1, m2);
    ImprimirMatriz(sumaMatrices);

    //Eliminar matrices
    EliminarMatriz(m1);
    EliminarMatriz(m2);
    EliminarMatriz(sumaMatrices);
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
