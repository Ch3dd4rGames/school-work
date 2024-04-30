// ConsoleApplication3.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;

/*
int sumar(int arr[], size_t arr_size)
{
    int suma = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr': " << arr[i] << endl;
        suma += arr[i];
    }
    return suma;
}

//Debe devolver la suma de todos los valores del array

int main()
{
    int miarray[6] = { 8, 3, 1, -9, 5, 2 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    int suma = sumar(miarray, tam);
    cout << "La suma de todos los valores del array es " << suma << endl;
}
*/

/*
int multiplicar(int arr[], size_t arr_size)
{
    int multiplicacion = 1;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr': " << arr[i] << endl;
        multiplicacion *= arr[i];
    }
    return multiplicacion;
}

//Debe devolver la multiplicación de todos los valores del array

int main()
{
    int miarray[6] = { 8, -3, 1, -9, 5, 2 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    int multiplicacion = multiplicar(miarray, tam);
    cout << "La suma de todos los valores del array es " << multiplicacion << endl;
}
*/

/*
string concat(string arr[], size_t arr_size)
{
    string concatenacion = "";
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de cadenas 'arr': " << arr[i] << endl;
        concatenacion += arr[i];
    }
    return concatenacion;
}

//Debe devolver la cadena formada por la concatenación de todas las cadenas almacenadas en el array

int main()
{
    string miarray[6] = { "Hola,", " ¿qué", " tal?", " Me", " llamo", " Eder" };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    string concatenacion = concat(miarray, tam);
    cout << "La cadena formada por la concatenación de valores del array es: " << concatenacion << endl;
}
*/

/*
int max(int arr[], size_t arr_size)
{
    int maximo = arr[0];
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr': " << arr[i] << endl;
        if (arr[i] > maximo)
            maximo = arr[i];
    }
    return maximo;
}

//Debe devolver el entero máximo almacenado en el array

int main()
{
    int miarray[6] = { -8, -3, -1, -9, -5, -2 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    int maximo = max(miarray, tam);
    cout << "El entero máximo de los valores del array es " << maximo << endl;
}
*/

/*
bool member_ord(int elem, int arr[], size_t arr_size)
{
    int asteriscos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr': " << arr[i] << endl;
        if (arr[i] == elem)
            return true;
        else if (arr[i] > elem)
            return false;
    }
    return false;
}

//Debe indicar si el elemento 'elem' está en el array, el cuál se asume que está ordenado de menor a mayor

int main()
{
    int miarray[6] = { 2, 5, 11, 27, 45, 69 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    size_t elem;
    cout << "Introduce un número: " << endl;
    cin >> elem;
    bool result = member_ord(elem, miarray, tam);
    if (result == true)
        cout << "En el array SI está el número " << elem << endl;
    else
        cout << "En el array NO está el número " << elem << endl;
}
*/

/*
bool arrays_iguales(int arr1[], size_t arr_size1, int arr2[], size_t arr_size2)
{
    if (arr_size1 != arr_size2)
        return false;
    for (int i = 0; i < arr_size1; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr1': " << arr1[i] << endl;
        cout << "Posición número " << i << " del array de enteros 'arr2': " << arr2[i] << endl;
        if (arr1[i] != arr2[i])
            return false;
    }
    return true;
}

//Debe indicar si los dos arrays almacenan los mismos elementos de izquierda a derecha

int main()
{
    int miarray1[6] = { 2, 5, 11, 27, 45, 69 };
    int miarray2[6] = { 2, 5, 11, -27, 45, 69 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam1 = sizeof(miarray1) / sizeof(miarray1[0]);
    int tam2 = sizeof(miarray2) / sizeof(miarray2[0]);
    bool result = arrays_iguales(miarray1, tam1, miarray2, tam2);
    if (result == true)
        cout << "Los dos arrays son iguales" << endl;
    else
        cout << "Los dos arrays no son iguales" << endl;
}
*/

void reverse(int arr[], size_t arr_size)
{
    int contador = arr_size;
    int almacenador;
    for (int i = 0; i < arr_size / 2; i++)
    {
        contador--;
        almacenador = arr[i];
        arr[i] = arr[contador];
        arr[contador] = almacenador;
    }
    for (int i = 0; i < arr_size; i++)
        cout << "Posición número " << i << " del array de enteros 'arr' inverso: " << arr[i] << endl;
}

//Debe modificar el array dejando sus elementos en orden inverso

int main()
{
    int miarray[6] = { 2, 5, 11, 27, 45, 69 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    reverse(miarray, tam);
}

/*
void substitute(int a, int b, int arr[], size_t arr_size)
{
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr': " << arr[i] << endl;
        if (arr[i] == a)
            arr[i] = b;
    }
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr' modificado: " << arr[i] << endl;
    }
}

//Modifica el array sustituyendo las apariciones de a por el elemento b

int main()
{
    int miarray[6] = { 2, 5, 45, 27, 45, 69 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    int a, b;
    cout << "Introduce un valor entero para el elemento a: " << endl;
    cin >> a;
    cout << "Introduce un valor entero para el elemento b: " << endl;
    cin >> b;
    substitute(a, b, miarray, tam);
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
