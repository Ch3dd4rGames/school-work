#include "Cuadrado.h"
#include <cstddef> // std::size_t


Cuadrado::Cuadrado::Figura::Figura(std::string nombre, std::size_t lado) :
    nombre{ nombre }, perimetro{ lado * 4 } {}

std::size_t Cuadrado::Figura::get_perimetro() const { return perimetro; }

std::string Cuadrado::Figura::get_nombre() const { return nombre; }

double Cuadrado::Figura::area() const
{
    return lado * lado;
}
