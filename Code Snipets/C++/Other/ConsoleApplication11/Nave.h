#pragma once
#include "Punto.h"
/*
class Persona
{
    //Atributos
    //C# -- private int edad
private:
    string nombre;
    int id;
    //Campos de bits
    unsigned sexo : 1; //0 = M y 1 = F
    unsigned edad : 7; //0-127 (7 bits)
    //Metodos
public:
    //Constructor por defecto
    //Forma de hacerlo en C++
    Persona();
    //Forma de hacerlo en C#
    /*
    Persona()
    {
        nombre = "";
        id = 0;
        sexo = 0;
        edad = 0;
    }
    */
    //Constructor explicito con argumentos
    //C++
//Persona(string, int, int, int);
//C#
/*
Persona(string nombre_, int id_, int sexo_, int edad_)
{
    nombre = nombre_;
    id = id_;
    sexo = sexo_;
    edad = edad_;
}
*/
//Constructor copia -- Copia un objeto de la clase en el objeto que se crea
//Persona(const Persona& p);

//void imprimirAtributos();
//};

class Nave
{ 
public:
    Nave(Punto, int);
    int vidas;
    Punto coordenadas;
    void subir();
    void bajar();
    void izquierda();
    void derecha();
    void danio();
};



