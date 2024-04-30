// ConsoleApplication6.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;

/*
struct Persona
{
    string nombre;
    size_t edad = 18;
};

struct Fecha
{
    size_t dia, mes, anio;
}f2; //Declarar variable de tipo estructura Fecha

int main()
{
    struct Fecha f1 = { 23, 5, 2000 };
    f2 = { 3, 8, 2010 };
    struct Persona p1; //Declarar variable de tipo estructura Persona
    p1 = { "Maria" }; //Inicializar la estructura creada
    cout << "Nombre: " << p1.nombre << endl;
    cout << "Edad: " << p1.edad << endl;
    p1.edad = 34; //Modificar el valor
    struct Persona p2 = { "Juan", 40 };
    struct Persona* ptr_estructura = &p1; //Puntero a estructuras
    //cout << "Nombre: " << *(ptr_estructura).nombre << endl;
    cout << "Nombre: " << ptr_estructura -> nombre << endl;
    cout << "Edad: " << ptr_estructura -> edad << endl;
    struct Persona array[2] = { p1, p2 }; //Array de estructuras
    cout << "Nombre: " << array[0].nombre << endl;
    cout << "Edad: " << array[0].edad << endl;
    struct Persona* ptr_array_estructuras = array;
    cout << "Nombre: " << ptr_array_estructuras -> nombre << endl;
    cout << "Edad: " << ptr_array_estructuras -> edad << endl;
    cout << "Nombre: " << (ptr_array_estructuras + 1) -> nombre << endl;
    cout << "Edad: " << (ptr_array_estructuras + 1) -> edad << endl;
}
*/

/*
//Declaración de funciones --> Fichero .h
int suma(int a, int b);

//Main
int main()
{
    suma(3, 6);
}

//Implementación de las funciones declaradas --> Fichero .cpp
int suma(int a, int b)
{
    return a + b;
}
*/

/*
//Declaración de funciones --> Fichero .h
void Contrasenia(string contrasenia);

//Main
int main()
{
    string contrasenia = "123";
    cout << "Buenas. Por favor, introduzca la contraseña: " << endl;
    Contrasenia(contrasenia);
    cout << "¡Tenga un buen día!" << endl;
}

//Implementación de las funciones declaradas --> Fichero .cpp
 void Contrasenia(string contrasenia)
{
     string intento;
     do
     {
         cin >> intento;
         if (intento == contrasenia)
             cout << "Contraseña correcta." << endl;
         else
             cout << "Contraseña incorrecta. Por favor, inténtelo de nuevo." << endl;
     } while (intento != contrasenia);
}
*/

/*
void Incrementar(int num); //Paso por valor
void Incrementar(int* num); //Paso por referencia a través de punteros
//void Incrementar(ref int num); C#
void IncrementarPorRef(int& num); //Paso por referencia a través de referencias

int main()
{
    //Ejemplo paso por valor
    int a = 5;
    Incrementar(a);
    cout << "a: " << a << endl;
    //Ejemplo paso por referencia a través de punteros
    int b = 7;
    Incrementar(&b);
    cout << "b: " << b << endl;
    //Ejemplo paso por referencia a través de referencias
    int c = 10;
    IncrementarPorRef(c);
    cout << "c: " << c << endl;
}

void Incrementar(int num)
{
    num++;
}
void Incrementar(int* num)
{
    *num++;
}
void IncrementarPorRef(int &num)
{
    num++;
}
*/

int Cuadrado(int &num);
int Maximo(int n1, int n2, int n3);
void Intercambiar(int& n1, int& n2);
void CambiarSigno(int arr[],int tam);
struct Fecha
{
    size_t dia, mes, anio;
};
Fecha FechaReciente(Fecha f1, Fecha f2);
struct NumeroComplejo
{
    int real, imaginario;
};
void Suma(NumeroComplejo n1, NumeroComplejo n2);
struct Alumno
{
    string nombre, apellido;
    float notaMedia;
};
Alumno MayorNota(Alumno a1, Alumno a2, Alumno a3);
void ElementosImpares(int arr[], int tam);
struct Persona
{
    string nombre;
    bool profesor = true;
};
void Clasificar(Persona personas[5]);

/*
int main()
{
    int num = 10;
    int cuad = Cuadrado(num);
}

int main()
{
    int n1 = 4, n2 = 9, n3 = 2;
    int max = Maximo(n1, n2, n3);
}

int main()
{
    int n1 = 3, n2 = 7;
    Intercambiar(n1, n2);
}

int main()
{
    int arr[5] = { 4, -3, -7, 0, 6};
    int tam = 5;
    CambiarSigno(arr, tam);
}

int main()
{
    struct Fecha f1 = { 23, 5, 2000 };
    struct Fecha f2 = { 3, 8, 2010 };
    struct Fecha reciente = FechaReciente(f1, f2);
}

int main()
{
    struct NumeroComplejo n1 = { 3, 5 };
    struct NumeroComplejo n2 = { -2, 7 };
    Suma(n1, n2);
}

int main()
{
    struct Alumno a1 = { "Roberto", "Sanchez", 8.1 };
    struct Alumno a2 = { "Lara", "Blanco", 8.1 };
    struct Alumno a3 = { "Andy", "Torres", 8.1 };
    struct Alumno destacado = MayorNota(a1, a2, a3);
    cout << "{ " << destacado.nombre << ", " << destacado.apellido << ", " << destacado.notaMedia << " }" << endl;
}

int main()
{
    int arr[5] = { 5, 1, -3, 4, 7 };
    int tam = sizeof(arr) / sizeof(arr[0]);
    ElementosImpares(arr, tam);
}
*/

int main()
{
    struct Persona p1 = { "Sandra", true };
    struct Persona p2 = { "Luis", true };
    struct Persona p3 = { "Rodrigo", false };
    struct Persona p4 = { "Raúl", true };
    struct Persona p5 = { "Alejandro", false };
    struct Persona personas[5] = { p1, p2, p3, p4, p5 };
    Clasificar(personas);
}

int Cuadrado(int& num)
{
    return num * num;
}
int Maximo(int n1, int n2, int n3)
{
    if (n1 >= n2 && n1 >= n3)
        return n1;
    else if (n2 >= n3)
        return n2;
    else
        return n3;
}
void Intercambiar(int& n1, int& n2)
{
    int almacenador = n1;
    n1 = n2;
    n2 = almacenador;
}
void CambiarSigno(int arr[], int tam)
{
    for (int i = 0; i < tam; i++)
        arr[i] = -arr[i];
}
Fecha FechaReciente(Fecha f1, Fecha f2)
{
    if (f1.anio != f2.anio)
    {
        if (f1.anio > f2.anio)
            return f1;
        else
            return f2;
    }
    else if (f1.mes != f2.mes)
    {
        if (f1.mes > f2.mes)
            return f1;
        else
            return f2;
    }
    else if (f1.dia != f2.dia)
    {
        if (f1.dia > f2.dia)
            return f1;
        else
            return f2;
    }
    else
        return f1;
}
void Suma(NumeroComplejo n1, NumeroComplejo n2)
{
    struct NumeroComplejo suma = { n1.real + n2.real, n1.imaginario + n2.imaginario };
}
Alumno MayorNota(Alumno a1, Alumno a2, Alumno a3)
{
    if (a1.notaMedia >= a2.notaMedia && a1.notaMedia >= a3.notaMedia)
        return a1;
    else if (a2.notaMedia >= a3.notaMedia)
        return a2;
    else
        return a3;
}
void ElementosImpares(int arr[], int tam) 
{
    for (int i = 0; i < tam; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
            int j = i;
            while (arr[i] % 2 == 0 && j < tam)
            {
                if (arr[j] % 2 != 0)
                {
                    arr[i] = arr[j];
                    arr[j] = 0;
                }
                j++;
            }
        }
    }
}
void Clasificar(Persona personas[5])
{
    struct Persona alumnos[5], profesores[5];
    size_t contadorAlumnos = 0, contadorProfesores = 0;
    for (int i = 0; i < 5; i++)
    {
        if (personas[i].profesor)
        {
            profesores[contadorProfesores] = personas[i];
            contadorProfesores++;
        }
        else
        {
            alumnos[contadorAlumnos] = personas[i];
            contadorAlumnos++;
        }
    }
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
