// ConsoleApplication16.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <stdlib.h>
#include <time.h>
#include <iostream>
#include "Urna.h"
using namespace std;

int main()
{
    Urna urna;
    int bola, decision, contador = 0;
    int bolasSacadas[100];
    srand(time(NULL));
    urna.MeterTodasLasBolas(urna.bombo);
    cout << "En el bombo hay " << urna.bolas << " bolas." << endl;
    do
    {
        for (int i = 0; i < urna.bolas; i++)
        {
            cout << *(urna.bombo + i) << ", ";
        }
        cout << "¿Qué quieres hacer ahora?" << endl;
        cout << "1. Sacar bola." << endl;
        cout << "2. Meter bola." << endl;
        cout << "3. Meter todas las bolas." << endl;
        cout << "4. Salir." << endl;
        cin >> decision;
        switch (decision)
        {
            case 1:
                if (urna.bolas == 0)
                    cout << "Ya no quedan bolas en la urna." << endl;
                else
                {
                    bola = 1 + rand() % (urna.bolas);
                    urna.bolas--;
                    bola = urna.SacarBola(urna.bombo, urna.bolas, bola);
                    *(bolasSacadas + contador) = bola;
                    contador++;
                    cout << "Has sacado la bola número " << bola << "." << endl;
                }
                break;
            case 2:
                if (urna.bolas == 100)
                    cout << "Ya están metidas todas las bolas en la urna." << endl;
                else
                {
                    bola = *(bolasSacadas);
                    for (int i = 0; i < contador; i++)
                    {
                        if (bola > *(bolasSacadas + i))
                            bola = *(bolasSacadas + i);
                    }
                    for (int i = 0; i < contador; i++)
                    {
                        if (*(bolasSacadas + i) == bola)
                            *(bolasSacadas + i) = 1000;
                    }
                    urna.bolas++;
                    urna.MeterBola(urna.bombo, urna.bolas, bola);
                    contador--;
                    cout << "Has metido la bola " << bola << " que sacaste de vuelta en la urna." << endl;

                }
                break;
            case 3:
                if (urna.bolas == 100)
                    cout << "Ya están metidas todas las bolas en la urna." << endl;
                else
                {
                    urna.bolas = 100;
                    urna.MeterTodasLasBolas(urna.bombo);
                    cout << "Has metido todas las bolas que sacaste de vuelta en la urna." << endl;
                }
                break;
            case 4:
                break;
            default:
                cout << "No has insertado un número válido." << endl;
                break;
        }
        if (decision != 4)
            cout << "Ahora hay " << urna.bolas << " bolas." << endl;
    } while (decision != 4);
    cout << "¡Gracias por participar!" << endl;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
