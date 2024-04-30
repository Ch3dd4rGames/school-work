#include "Punto.h"

//Fichero .h -- void imprimirAtributos();
/*
void Persona :: imprimirAtributos()
{
    std::cout << "La edad es " << edad;
}

Persona :: Persona() : nombre{""}, id{0}, sexo{0}, edad{0} {}
Persona :: Persona(string nombre_, int id_, int sexo_, int edad_) : nombre{nombre_}, id{id_ = 0}, sexo{sexo_ = 1}, edad{edad_ = 18} {}
Persona :: Persona(const Persona& p) : nombre{p.nombre}, id{p.id}, sexo{p.sexo}, edad{p.edad} {}
*/

Punto :: Punto() : x{100}, y{100} {}

Punto :: Punto(int x_, int y_) : x{x_}, y{y_} {}

void Punto::set_x(int x_) 
{
    x += x_;
}

void Punto::set_y(int y_) 
{
    y += y_;
}

