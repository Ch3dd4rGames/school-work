// ConsoleApplication2.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;

/*
bool member(int elem, int arr[], size_t arr_size) 
{
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de enteros 'arr': " << arr[i] << endl;
        if (arr[i] == elem)
            return true;
    }
    return false;
}

//Debe indicar si el entero 'elem' está en el array de enteros 'arr'

int main()
{
    int miarray[6] = { 1, 7, 9, 3, 6, 0 };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    bool result = member(7, miarray, tam);
    if (result == true)
        cout << "El entero 'elem' SI está en el array de enteros 'arr'" << endl;
    else
        cout << "El entero 'elem' NO está en el array de enteros 'arr'" << endl;
}
*/

/*
bool num_pares_ast(char arr[], size_t arr_size)
{
    int pares = 0, asteriscos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (i % 2 == 0)
        {
            pares++;
            if (arr[i] == '*')
                asteriscos++;
        }
    }
    if (pares == asteriscos)
        return true;
    else
        return false;
}

//Debe indicar si en todas las posiciones pares del array hay un carácter asterisco

int main()
{
    char miarray[6] = { '*', 'a', '*', '+', '*', '!' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    bool result = num_pares_ast(miarray, tam);
    if (result == true)
        cout << "En todas las posiciones pares del array SI hay un carácter asterisco" << endl;
    else
        cout << "En todas las posiciones pares del array NO hay un carácter asterisco" << endl;
}
*/

/*
bool al_menos_tres_ast(char arr[], size_t arr_size)
{
    int asteriscos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (arr[i] == '*')
            asteriscos++;
        if (asteriscos >= 3)
            return true;
    }
    return false;
}

//Debe indicar si en el array hay al menos 3 asteriscos

int main()
{
    char miarray[6] = { '*', '<', 'a', '+', '*', '!' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    bool result = al_menos_tres_ast(miarray, tam);
    if (result == true)
        cout << "En el array SI hay al menos 3 asteriscos" << endl;
    else
        cout << "En el array NO hay al menos 3 asteriscos" << endl;
}
*/

/*
bool tres_ast(char arr[], size_t arr_size)
{
    int asteriscos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (arr[i] == '*')
            asteriscos++;
    }
    if (asteriscos == 3)
        return true;
    else
        return false;
}

//Debe indicar si en el array hay exactamente 3 asteriscos

int main()
{
    char miarray[6] = { '*', '<', '*', '+', '*', '!' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    bool result = tres_ast(miarray, tam);
    if (result == true)
        cout << "En el array SI hay exactamente 3 asteriscos" << endl;
    else
        cout << "En el array NO hay exactamente 3 asteriscos" << endl;
}
*/

/*
bool tres_ast_consec(char arr[], size_t arr_size)
{
    int asteriscos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (arr[i] == '*')
        {
            asteriscos++;
        }
        else
        {
            asteriscos = 0;
        }
        if (asteriscos == 3)
        {
            return true;
        }
    }
    return false;
}

//Debe indicar si en el array hay 3 asteriscos consecutivos

int main()
{
    char miarray[6] = { '*', '*', 'a', '*', '*', '*' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    bool result = tres_ast_consec(miarray, tam);
    if (result == true)
        cout << "En el array SI hay 3 asteriscos seguidos" << endl;
    else
        cout << "En el array NO hay 3 asteriscos seguidos" << endl;
}
*/

/*
size_t tres_grupos_ast_consec(char arr[], size_t arr_size)
{
    int asteriscos = 0;
    size_t grupos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (arr[i] == '*')
        {
            asteriscos++;
        }
        else
        {
            asteriscos = 0;
        }
        if (asteriscos == 3)
        {
            grupos++;
            asteriscos = 0;
        }
    }
    return grupos;
}

//Debe indicar cuantos grupos de 3 asteriscos consecutivos hay

int main()
{
    char miarray[10] = { '*', '*', 'a', '*', '*', '*', '!', '*', '*', '*' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    size_t grupos = tres_grupos_ast_consec(miarray, tam);
    cout << "En el array hay " << grupos << " grupo(s) de 3 asteriscos seguidos" << endl;
}
*/

size_t n_grupos_ast_consec(size_t n, char arr[], size_t arr_size)
{
    int asteriscos = 0;
    size_t grupos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (arr[i] == '*')
        {
            asteriscos++;
        }
        else
        {
            asteriscos = 0;
        }
        if (asteriscos == n)
        {
            grupos++;
            asteriscos = 0;
        }
    }
    return grupos;
}

//Debe indicar cuantos grupos de n asteriscos consecutivos hay

int main()
{
    char miarray[10] = { '*', '*', 'a', '*', '*', '*', '!', '*', '*', '*' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    size_t n;
    cout << "Introduce un número: " << endl;
    cin >> n;
    size_t grupos = n_grupos_ast_consec(n, miarray, tam);
    cout << "En el array hay " << grupos << " grupo(s) de " << n << " asteriscos seguidos" << endl;
}

/*
bool n_ast_consec(size_t n, char arr[], size_t arr_size)
{
    int asteriscos = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (arr[i] == '*')
        {
            asteriscos++;
        }
        else
        {
            asteriscos = 0;
        }
        if (asteriscos == n)
        {
            return true;
        }
    }
    return false;
}

//Debe indicar si en el array hay n cantidad de asteriscos consecutivos

int main()
{
    char miarray[6] = { '*', '*', 'a', '*', '*', '*' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    size_t n;
    cout << "Introduce un número: " << endl;
    cin >> n;
    bool result = n_ast_consec(n, miarray, tam);
    if (result == true)
        cout << "En el array SI hay " << n << " asterisco(s) seguido(s)" << endl;
    else
        cout << "En el array NO hay " << n << " asterisco(s) seguido(s)" << endl;
}
*/

/*
size_t num_apar(char elem, char arr[], size_t arr_size)
{
    size_t apariciones = 0;
    for (int i = 0; i < arr_size; i++)
    {
        cout << "Posición número " << i << " del array de carácteres 'arr': " << arr[i] << endl;
        if (arr[i] == elem)
            apariciones++;
    }
    return apariciones;
}

//Debe indicar si en el array se encuentra el carácter pedido y la cantidad de apariciones

int main()
{
    char miarray[6] = { '*', '<', 'a', '+', 'j', '!' };
    //Calcular tamaño del array
    //Tamaño total / tamaño de cada variable
    int tam = sizeof(miarray) / sizeof(miarray[0]);
    char elem;
    cout << "Introduce un carácter: " << endl;
    cin >> elem;
    size_t apariciones = num_apar(elem, miarray, tam);
    if (apariciones == 0)
        cout << "En el array NO está presente el carácter pedido" << endl;
    else
        cout << "En el array SI está presente el carácter pedido. Sale " << apariciones << " cantidad de veces." << endl;
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
