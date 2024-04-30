// ConsoleApplication7.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <iostream>
using namespace std;

/*
int factorialRec(int numero)
{
    int resultado;
    if (numero == 1)
        resultado = 1; //Caso no recursivo
    else
        resultado = numero * factorialRec(numero - 1); //Caso recursivo
    return resultado;
}

int main()
{
    int numero;
    cin >> numero;
    int factorial = factorialRec(numero);
    cout << factorial;
}
*/

void ConvertirABinario(int numero)
{
    if (numero > 0)
    {
        ConvertirABinario(numero / 2);
        cout << numero % 2;
    }
}

int main()
{
    int numero;
    cout << "Dime un número entero" << endl;
    cin >> numero;
    cout << numero << " en binario es ";
    ConvertirABinario(numero);
}


void Invertir(int num)
{
    if (num < 10)
        cout << num;
    else 
    {
        cout << num % 10;
        Invertir(num / 10);
    }
}

int main()
{
    int num;
    cout << "Dime un número entero" << endl;
    cin >> num;
    cout << num << " al revés es ";
    Invertir(num);
}

bool ComprobarPalindromo(string palabra) 
{
    if (palabra.length() <= 1) //Caso base. Una palabra de un solo caracter es palíndroma
        return true;
    //Convierte los caracteres que va a comparar en minúsculas
    char first = tolower(palabra[0]);
    char last = tolower(palabra[palabra.length() - 1]);
    //Compara el primer y último caracter de la palabra
    if (first != last)
        return false;
    //Llama a la función recursivamente con la palabra sin el primer y último caracteres
    return ComprobarPalindromo(palabra.substr(1, palabra.length() - 2));
}

int main()
{
    string palabra;
    cout << "Dime una palabra" << endl;
    cin >> palabra;
    if (ComprobarPalindromo(palabra))
        cout << "La palabra " << palabra << " es palíndroma." << endl;
    else
        cout << "La palabra " << palabra << " no es palíndroma." << endl;
}

int ElevarPotencia(int base, int potencia)
{
    if (potencia == 0) // Caso base
        return 1;
    else if (potencia > 0)
        return base * ElevarPotencia(base, potencia - 1);
    else
        return (1 / base) * ElevarPotencia(base, potencia + 1);
}

int main()
{
    int base, potencia;
    cout << "Dime el número base" << endl;
    cin >> base;
    cout << "Dime la potencia" << endl;
    cin >> potencia;
    int resultado = ElevarPotencia(base, potencia);
    cout << "El resultado es " << resultado << endl;
}

int SumaNaturales(int numero, int naturales, int suma)
{
    if (naturales < numero)
    {
        naturales++;
        suma += naturales;
        return SumaNaturales(numero, naturales, suma);
    }
    else
        return suma;
}

int main()
{
    int numero;
    cout << "Dime un número" << endl;
    cin >> numero;
    int resultado = SumaNaturales(numero, 0, 0);
    cout << "Tras sumar todos los números naturales hasta " << numero << ", el resultado es " << resultado << endl;
}

int TerminoFibonacci(int numero, int sucesion, int anterior)
{
    if (numero > 0)
    {  
        if (sucesion == 0)
            sucesion++;
        else
        {
            sucesion += anterior;
            anterior = sucesion - anterior;
        }
        numero--;
        return TerminoFibonacci(numero, sucesion, anterior);
    }
    else
        return sucesion;
}

int main()
{
    int numero;
    cout << "Dime un número" << endl;
    cin >> numero;
    int termino = TerminoFibonacci(numero, 0, 0);
    cout << "El término " << numero << " de la sucesión de Fibonacci es " << termino << endl;
}

int SumaCifras(int numero) 
{
    if (numero < 10) 
        return numero;
    else
        return numero % 10 + SumaCifras(numero / 10);
}

int main() 
{
    int numero;
    cout << "Dime un número entero" << endl;
    cin >> numero;
    int suma = SumaCifras(numero);
    cout << "La suma de los dígitos de " << numero << " es " << suma;
}

void NumerosEnMedio(int n1, int n2)
{
    int resultado;
    if (n1 <= n2)
    {
        cout << n1;
        if (n1 != n2)
        {
            cout << ", ";
        }
        NumerosEnMedio(n1 + 1, n2);
    }
}

int main()
{
    int n1, n2;
    cout << "Dime un primer número entero" << endl;
    cin >> n1;
    cout << "Dime un segundo número entero más grande que el primero" << endl;
    cin >> n2;
    cout << "Los números entre " << n1 << " y " << n2 << " son los siguientes: ";
    NumerosEnMedio(n1, n2);
}

string Invertir(string abc, size_t cont)
{
    string alm;
    if (cont > abc.length() / 2)
    {
        return abc;
    }
    else
    {
        alm[0] = abc[cont - 1];
        abc[cont - 1] = abc[abc.length() - cont];
        abc[abc.length() - cont] = alm[0];
        cont++;
        return Invertir(abc, cont);
    }
}

int main()
{
    string alReves = Invertir("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ", 1);
    cout << alReves;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
