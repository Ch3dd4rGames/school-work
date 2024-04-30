#include "Figura.h"
#include <cstddef> // std::size_t


Figura::Figura(std::string nombre, std::size_t lado) :
    nombre{ nombre }, perimetro{ lado * 4 } {}

std::size_t Figura::get_perimetro() const { return perimetro; }

std::string Figura::get_nombre() const { return nombre; }

double Figura::area() const {}

