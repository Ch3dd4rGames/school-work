#include "Punto2D.h"

Punto2D::Punto2D(int x_, int y_) : x{x_}, y{y_} {}
const int Punto2D::getx() 
{
    return x;
}
const int Punto2D::gety() 
{
    return y;
}
void Punto2D::setx(int x_) 
{
    x = x_;
}
void Punto2D::sety(int y_) 
{
    y = y_;
}