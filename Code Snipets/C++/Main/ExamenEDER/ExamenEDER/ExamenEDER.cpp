// ExamenEDER.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;
#define N 1000

struct EstadisticasJuego
{
    int tiempoTotalJugado;
    int puntajeMaximo;
};
struct Videojuego 
{
    int id;
    string titulo;
    string desarrolladora;
    float precio;
    EstadisticasJuego* estadísticas;
};
struct Jugador 
{
    int id;
    string nombre;
    double saldo;
    Videojuego* juegosComprados[10];
    int numJuegosComprados;
};
typedef Videojuego* ptrVid;
typedef ptrVid vArray[N];
typedef Jugador* ptrJug;
typedef ptrJug jArray[N];
struct vLista
{
    vArray registros;
    int cont;
};
struct jLista
{
    jArray registros;
    int cont;
};

void comprarJuego(Jugador* jugador, Videojuego* juego);
void devolverJuego(Jugador* jugador, Videojuego* juego);
void listarCompras(Jugador* jugador);
void registrarEstadisticas(Jugador* jugador, Videojuego* juego);
void generarInformeVideojuegosPopulares();
void mostrarJugadores(jLista& lista);
void mostrarVideojuegos(vLista& lista);

int main()
{
    vLista listaJuegos;
    *(listaJuegos.registros) = new Videojuego({ 4365, "Super Mario Wonder", "Nintendo", 59.99f, 0 });
    *(listaJuegos.registros + 1) = new Videojuego({ 6974, "Spiderman 2", "Sony Interactive", 69.99f, 0 });
    *(listaJuegos.registros + 2) = new Videojuego({ 1530, "The Legend of Zelda: Tears of the Kingdom", "Nintendo", 69.99f, 0 });
    *(listaJuegos.registros + 3) = new Videojuego({ 5478, "FC24", "EA Sports", 69.99f, 0 });
    *(listaJuegos.registros + 4) = new Videojuego({ 8019, "Starfield", "Activision Blizzard", 59.99f, 0 });
    listaJuegos.cont = 5;
    jLista listaJugadores;
    *(listaJugadores.registros) = new Jugador({ 3216, "Eder", 300, {*(listaJuegos.registros + 2)}, 1 });
    *(listaJugadores.registros + 1) = new Jugador({ 2382, "Rodrigo", 150, {*(listaJuegos.registros + 3), *(listaJuegos.registros + 4)}, 2 });
    *(listaJugadores.registros + 2) = new Jugador({ 7235, "Jorge", 500, {*(listaJuegos.registros), *(listaJuegos.registros + 1), *(listaJuegos.registros + 3)}, 3 });
    listaJugadores.cont = 3;
    int eleccion, id;
    Jugador* jugador;
    do 
    {
        cout << "Bienvenido a nuestra tienda. ¿Qué quiere hacer?" << endl;
        cout << "1. Comprar un juego." << endl;
        cout << "2. Devolver un juego." << endl;
        cout << "3. Ver perfiles." << endl;
        cout << "4. Ver juegos disponibles." << endl;
        cout << "5. Registrar estadísticas." << endl;
        cout << "6. Ver juegos ordenados por popularidad." << endl;
        cout << "7. Salir." << endl;
        cin >> eleccion;
        switch (eleccion)
        {
            case 1:
                mostrarJugadores(listaJugadores);
                cout << "¿Quien es? (0-2) " << endl;
                cin >> id;
                switch (id)
                {
                    case 0:
                        jugador = *(listaJugadores.registros);
                        break;
                    case 1:
                        jugador = *(listaJugadores.registros + 1);
                        break;
                    default:
                        jugador = *(listaJugadores.registros + 2);
                        break;
                }
                mostrarVideojuegos(listaJuegos);
                cout << "¿Que juego quiere comprar? (0-4) " << endl;
                cin >> id;
                switch (id)
                {
                case 0:
                    comprarJuego(jugador, *(listaJuegos.registros));
                    break;
                case 1:
                    comprarJuego(jugador, *(listaJuegos.registros + 1));
                    break;
                case 2:
                    comprarJuego(jugador, *(listaJuegos.registros + 2));
                    break;
                case 3:
                    comprarJuego(jugador, *(listaJuegos.registros + 3));
                    break;
                case 4:
                    comprarJuego(jugador, *(listaJuegos.registros + 4));
                    break;
                }
                break;
            case 2:
                mostrarJugadores(listaJugadores);
                cout << "¿Quien es? (0-2) " << endl;
                cin >> id;
                switch (id)
                {
                case 0:
                    jugador = *(listaJugadores.registros);
                    break;
                case 1:
                    jugador = *(listaJugadores.registros + 1);
                    break;
                default:
                    jugador = *(listaJugadores.registros + 2);
                    break;
                }
                listarCompras(jugador);
                cout << "¿Que juego quiere devolver? (0-4) " << endl;
                cin >> id;
                switch (id)
                {
                case 0:
                    comprarJuego(jugador, *(listaJuegos.registros));
                    break;
                case 1:
                    comprarJuego(jugador, *(listaJuegos.registros + 1));
                    break;
                case 2:
                    comprarJuego(jugador, *(listaJuegos.registros + 2));
                    break;
                case 3:
                    comprarJuego(jugador, *(listaJuegos.registros + 3));
                    break;
                case 4:
                    comprarJuego(jugador, *(listaJuegos.registros + 4));
                    break;
                }
                break;
            case 3:
                mostrarJugadores(listaJugadores);
                break;
            case 4:
                mostrarVideojuegos(listaJuegos);
                break;
            case 5:

                break;
            case 6:

                break;
            default:
                break;
        }
    } while (eleccion != 7);

}

void mostrarJugadores(jLista& lista)
{
    for (int i = 0; i < lista.cont; i++)
    {
        cout << "Indice " << i << ":" << endl;
        cout << "Codigo: " << (*(lista.registros + i))->id << endl;
        cout << "Nombre: " << (*(lista.registros + i))->nombre << endl;
        cout << "Saldo: " << (*(lista.registros + i))->saldo << endl;
        cout << "Juegos comprados: " << endl; 
        listarCompras(*(lista.registros + i));
        cout << endl;
    }
}

void mostrarVideojuegos(vLista& lista)
{
    for (int i = 0; i < lista.cont; i++)
    {
        cout << "Indice " << i << ":" << endl;
        cout << "Codigo: " << (*(lista.registros + i))->id << endl;
        cout << "Titulo: " << (*(lista.registros + i))->titulo << endl;
        cout << "Desarrolladora: " << (*(lista.registros + i))->desarrolladora << endl;
        cout << "Precio: " << (*(lista.registros + i))->precio << endl;
        cout << endl;
    }
}

void comprarJuego(Jugador* jugador, Videojuego* juego)
{
    jugador->saldo -= juego->precio;
    jugador->numJuegosComprados++;
    *(jugador->juegosComprados + jugador->numJuegosComprados);
}

void devolverJuego(Jugador* jugador, Videojuego* juego)
{

}

void listarCompras(Jugador* jugador)
{
    for (int i = 0; i < jugador->numJuegosComprados; i++)
    {
        cout << jugador->juegosComprados << endl;
        cout << endl;
    }
}

void registrarEstadisticas(Jugador* jugador, Videojuego* juego)
{

}

void generarInformeVideojuegosPopulares()
{

}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
