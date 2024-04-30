#include <iostream>
#include "Circulo.h"
using namespace std;

Circulo::Circulo(float x, float y, float r) : x{ x }, y{ y }, r{ r } {} //Constructor de la estructura

double Circulo::area(float r) const
{
    return 3.14 * r * r;
}

float Circulo::mover(float dx, float dy)
{
    return this->x + dx, this->y + dy; //Suma las primeras y segundas coordenadas por separado
}

void Circulo::informacion()
{
    cout << "Círculo" << endl;
}

bool Circulo::operator==(Circulo c) const
{
    if (c.x == this->x && c.y == this->y && c.r == this->r)
        return true;
    else
        return false;
}