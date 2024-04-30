// ConsoleApplication12.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
#include "Nave.h"
#include<cstdlib>
using namespace std;
/*
int main()
{
    Persona p1 = Persona(); //Crear el objeto con el constructor por defecto
    Persona p2 = Persona("María", 1234, 0, 20); //Crear el objeto con el constructor explícito con argumentos
    Persona p3 = Persona(p1); //Crear el objeto con el constructor copia
}
*/

void Nave::subir()
{
    coordenadas.set_y(5);
    cout << "Te has movido arriba. La nueva posición de la nave es (" << coordenadas.x << ", " << coordenadas.y << ")" << endl;
}
void Nave::bajar()
{
    coordenadas.set_y(-5);
    cout << "Te has movido abajo. La nueva posición de la nave es (" << coordenadas.x << ", " << coordenadas.y << ")" << endl;
}
void Nave::izquierda()
{
    coordenadas.set_x(-5);
    cout << "Te has movido a la izquierda. La nueva posición de la nave es (" << coordenadas.x << ", " << coordenadas.y << ")" << endl;
}
void Nave::derecha()
{
    coordenadas.set_x(5);
    cout << "Te has movido a la derecha. La nueva posición de la nave es (" << coordenadas.x << ", " << coordenadas.y << ")" << endl;
}
void Nave::danio()
{
    vidas--;
    cout << "Te has chocado con un asteroide y has recibido daño. Ahora tienes " << vidas << " vidas " << endl;
}

Nave :: Nave(Punto coord, int vidas_) : coordenadas{coord}, vidas{vidas_ = 3}{}

int main()
{
    Nave n1 = Nave({100, 100}, 3); //Crear el objeto con el constructor por defecto
    int random, decision;
    char continuar = 's';
    srand((unsigned)time(NULL));
    do
    {
        cout << "Eres una nave espacial navegando la galaxia. Te encuentras en las coordenadas (" << n1.coordenadas.x << ", " << n1.coordenadas.y << ") y tienes " << n1.vidas << " vidas." << endl;
        do
        {
            cout << "¿Hacia dónde quieres ir?" << endl;
            cout << "1. Arriba" << endl;
            cout << "2. Abajo" << endl;
            cout << "3. Izquierda" << endl;
            cout << "4. Derecha" << endl;
            cin >> decision;
            switch (decision)
            {
            case 1:
                n1.subir();
                break;
            case 2:
                n1.bajar();
                break;
            case 3:
                n1.izquierda();
                break;
            case 4:
                n1.derecha();
                break;
            default:
                cout << "No te has movido" << endl;
                break;
            }
            random = rand() % 5;
            if (random == 0)
                n1.danio();
        } while (n1.vidas > 0);
        cout << "La nave se ha destruido. ¿Quieres crear otra nueva? (s/n)" << endl;
        cin >> continuar;
        if (tolower(continuar) == 's')
        {
            cout << "Introduce la posición x de la nueva nave:" << endl;
            cin >> n1.coordenadas.x;
            cout << "Introduce la posición y de la nueva nave:" << endl;
            cin >> n1.coordenadas.y;
            n1.vidas = 3;
        }
    } while (tolower(continuar) == 's');
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
