// ConsoleApplication10.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;
#define N 1000
typedef struct 
{
    int codigo;
    string nombre;
    double valor;
}tRegistro;
typedef tRegistro* ptrReg;
typedef ptrReg tArray[N];
typedef struct 
{
    tArray registros;
    int cont;
}tLista;

int buscar(const tLista& lista, int code); // Busca el código dentro de los elementos de la lista. Devuelve el índice o -1 si no lo encuentra
void mostrar(const tLista& lista); // Muestra la información de todos los elementos de la lista
void insertar(tLista& lista, tRegistro registro); // Inserta el registro en la lista
void eliminar(tLista& lista, int code); // Elimina el registro de la lista
void destruir(tLista& lista); // Elimina todos los elementos de la lista

int main()
{
    tLista lista;
    *(lista.registros) = new tRegistro({ 4365, "Sara", 7.5 });
    *(lista.registros + 1) = new tRegistro({ 6974, "Tulio", 3.4 });
    *(lista.registros + 2) = new tRegistro({ 1530, "Valeria", 1.2 });
    *(lista.registros + 3) = new tRegistro({ 9821, "Peter", 5.8 });
    *(lista.registros + 4) = new tRegistro({ 7656, "Walter", 9.1 });
    lista.cont = 5;
    int codigo;
    cout << "Inserte un código de 4 dígitos:" << endl;
    cin >> codigo;
    int resultado = buscar(lista, codigo);
    if (resultado < 0)
    {
        cout << "El código " << codigo << " no se encuentra en la lista" << endl;
    }
    else
    {
        cout << "El código " << codigo << " se encuentra en el índice " << resultado << " de la lista" << endl;
    }
    cout << endl;

    cout << "Los elementos de la lista son los siguientes:" << endl;
    mostrar(lista);
    
    tRegistro registro;
    cout << "Inserte un código de 4 dígitos:" << endl;
    cin >> registro.codigo;
    cout << "Inserte un nombre:" << endl;
    cin >> registro.nombre;
    cout << "Inserte un valor:" << endl;
    cin >> registro.valor;
    cout << "Este nuevo registro se añadirá a la lista" << endl;
    insertar(lista, registro);
    cout << endl;
    cout << "Como se puede ver a continuación:" << endl;
    mostrar(lista);

    cout << "Inserte el código del registro que quiera eliminar:" << endl;
    cin >> codigo;
    resultado = buscar(lista, codigo);
    if (resultado < 0)
    {
        cout << "El código " << codigo << " no se encuentra en la lista" << endl;
        cout << endl;
    }
    else
    {
        cout << "Ahora se eliminará el registro de código " << codigo << endl;
        eliminar(lista, codigo);
        cout << endl;
        cout << "Como se puede ver a continuación:" << endl;
        mostrar(lista);
    }
    cout << "Ahora se borrará la lista" << endl;
    destruir(lista);
    cout << "Se ha borrado exitosamente" << endl;
}

int buscar(const tLista& lista, int code)
{
    for (int i = 0; i < lista.cont; i++)
    {
        if ((*(lista.registros + i)) -> codigo == code)
            return i;
    }
    return -1;
}

void mostrar(const tLista& lista)
{
    for (int i = 0; i < lista.cont; i++)
    {
        cout << "Índice " << i << ":" << endl;
        cout << "Código: " << (*(lista.registros + i)) -> codigo << endl;
        cout << "Nombre: " << (*(lista.registros + i))-> nombre << endl;
        cout << "Valor: " << (*(lista.registros + i)) -> valor << endl;
        cout << endl;
    }
}

void insertar(tLista& lista, tRegistro registro)
{
    *(lista.registros + lista.cont) = new tRegistro;
    (*(lista.registros + lista.cont)) -> codigo = registro.codigo;
    (*(lista.registros + lista.cont)) -> nombre = registro.nombre;
    (*(lista.registros + lista.cont)) -> valor = registro.valor;
    lista.cont++;
}

void eliminar(tLista& lista, int code)
{
    int indice = buscar(lista, code);
    if (indice != -1) // Solo elimina el registro si existe en la lista
    { 
        delete *(lista.registros + indice);
        for (int i = indice + 1; i < lista.cont; i++) 
        {
            *(lista.registros + i - 1) = *(lista.registros + i);
        }
        lista.cont--;
    }
}
void destruir(tLista& lista)
{
    for (int i = 0; i < lista.cont; i++) 
    {
        delete *(lista.registros + i);
    }
    lista.cont = 0;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
