#include <iostream>
using namespace std;

/*
int main()
{
    int a = 5;
    int b = 7;
    int c = a + b;
    return 0;
}
*/

/*
int main()
{
    cout << "Size of char : " << sizeof(char) << endl;
    cout << "Size of int : " << sizeof(int) << endl;
    cout << "Size of short int : " << sizeof(short int) << endl;
    cout << "Size of long int : " << sizeof(long int) << endl;
    cout << "Size of float : " << sizeof(float) << endl;
    cout << "Size of double : " << sizeof(double) << endl;
    cout << "Size of wchar_t : " << sizeof(wchar_t) << endl;
    return 0;
}
*/

/*
int main()
{
    enum TipoEleccion { Piedra, Tijeras = 5, Papel };
    TipoEleccion Eleccion;
    cout << endl << endl << "Valor de Piedra: " << Piedra << endl;
    cout << "Valor de Tijeras: " << Tijeras << endl;
    cout << "Valor de Papel: " << Papel << endl;
    return 0;
}
*/

/*
int main()
{
    int v[5] = { 3,5,8,7,4 };
    for (int i = 0; i <= 10; i++)
    {
        cout << "Posición " << i << v[i] << endl;
    }
    return 0;
}
*/

/*
int main()
{
    int var1 = 3;
    int var2 = -98;
    int var3 = 25;
    cout << &var1 << endl;
    cout << &var2 << endl;
    cout << &var3 << endl;
    return 0;
}
*/

/*
int main()
{
    //Punteros y referencias
    int c = 5; //Variable entera, guarda c = 5 en memoria
    int* pc; //Creación puntero = dirección memoria, declara puntero a entero
    cout << "Dirección de c (&c): " << &c << endl; //Acceder a la dirección de memoria
    cout << "Valor de (c): " << c << endl << endl; //Acceder al valor
    pc = &c; //Referencia de la variable = dirección de memoria donde se guarda, guarda y apunta a la dirección de memoria de c
    cout << "La dirección del puntero pc almacena (pc): " << pc << endl; //Acceder a la dirección de memoria a la que apunta
    cout << "El contenido de la dirección del puntero pc almacena (*pc): << *pc << endl; //Acceder al valor que apunta
    c = 11; //Modifica el valor de c
    cout << "Dirección de c (&c): " << pc << endl;
    cout << "Valor de c (c): " << c << endl;
    *pc = 2; //Modifica el valor al que apunta pc
    cout << "La dirección del puntero pc almacena (pc): " << pc << endl;
    cout << "El contenido de la dirección del puntero pc almacena (*pc): << *pc << endl;
    return 0;
}
*/

/*
#define PI 3.14
#define CODIGO "r4er4"
#define VOCAL 'e'
#define CONSTANTE 't'
using namespace std;
int main()
{
    cout << "Dime el radio del círculo: " << endl;
    double radio;
    cin >> radio;
    cout << "El perímetro de un círculo de radio " << radio << " es: " << 2 * PI * radio << endl;
    cout << "El área de un círculo de radio " << radio << " es: " << PI * pow(radio, 2) << endl;
    return 0;
}
*/

int main()
{
    char letra[10];
    int vocales = 0;
    for (int i = 0; i < 10; i++)
    {
        cout << "Dime la letra número " << i + 1 << ":" << endl;
        cin >> letra[i];
        if (letra[i] == 'a' || letra[i] == 'e' || letra[i] == 'i' || letra[i] == 'o' || letra[i] == 'u')
            vocales++;
    }
    cout << "En total has escrito " << vocales << " vocales" << endl;
    return 0;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln

