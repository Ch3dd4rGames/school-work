#include "Rectangulo.h"

Rectangulo::Rectangulo(int l1, int l2)
{
    lado1 = l1;
    lado2 = l2;
}
const int Rectangulo::getlado1() {
    return lado1;
}
const int Rectangulo::getlado2() {
    return lado2;
}
Rectangulo& Rectangulo::operator = (const Rectangulo& c)
{
    if (&c != this)
    {
        lado1 = c.lado1;
        lado2 = c.lado2;
    }
    return *this;
}
//Sobrecarga del operador suma (+)
Rectangulo& Rectangulo::operator + (const Rectangulo& c)
{
    return *(new Rectangulo(this->lado1 + c.lado1, this->lado2 + c.lado2));
}
