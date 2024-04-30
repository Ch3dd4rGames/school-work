// ConsoleApplication11.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
using namespace std;
#define N 1000
struct Estudiante
{
    int id;
    string nombre;
    float calificacion;
};
typedef Estudiante* ptrEst;
typedef ptrEst tArray[N];
typedef struct
{
    tArray estudiantes;
    int cont;
}tLista;

void mostrarEstudiantes(const tLista& lista);
void actualizarCalificacion(Estudiante* estudiante, float nuevaCalificacion);

int main()
{
    tLista lista;
    *(lista.estudiantes) = new Estudiante({ 4365, "Sara", 7.5 });
    *(lista.estudiantes + 1) = new Estudiante({ 6974, "Tulio", 3.4 });
    *(lista.estudiantes + 2) = new Estudiante({ 1530, "Valeria", 1.2 });
    *(lista.estudiantes + 3) = new Estudiante({ 9821, "Peter", 5.8 });
    *(lista.estudiantes + 4) = new Estudiante({ 7656, "Walter", 9.1 });
    lista.cont = 5;
    mostrarEstudiantes(lista);
    int indice;
    float nota;
    char respuesta;
    bool seguir = true;
    do
    {
        do
        {
            cout << "Escoja el índice del estudiante cuya calificación quiera actualizar:" << endl;
            cin >> indice;
        } while (indice < 0 || indice > 4);
        do
        {
            cout << "Inserte la nueva calificación:" << endl;
            cin >> nota;
        } while (nota < 0 || nota > 10);
        cout << "Se actualizará la calificación " << (*(lista.estudiantes + indice)) -> calificacion << " del índice " << indice << " a " << nota << endl;
        actualizarCalificacion(*(lista.estudiantes + indice), nota);
        cout << endl;
        cout << "Como se puede ver a continuación:" << endl;
        mostrarEstudiantes(lista);
        cout << "¿Quiere cambiar alguna calificación más? (S/N)" << endl;
        cin >> respuesta;
        if (toupper(respuesta) == 'N')
            seguir = false;
    } while (seguir);
    cout << endl;
    cout << "Este es el resultado final:" << endl;
    mostrarEstudiantes(lista);
}

void mostrarEstudiantes(const tLista& lista)
{
    for (int i = 0; i < lista.cont; i++)
    {
        cout << "Índice " << i << ":" << endl;
        cout << "Código: " << (*(lista.estudiantes + i)) -> id << endl;
        cout << "Nombre: " << (*(lista.estudiantes + i)) -> nombre << endl;
        cout << "Valor: " << (*(lista.estudiantes + i)) -> calificacion << endl;
        cout << endl;
    }
}

void actualizarCalificacion(Estudiante* estudiante, float nuevaCalificacion)
{
    estudiante -> calificacion = nuevaCalificacion;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
