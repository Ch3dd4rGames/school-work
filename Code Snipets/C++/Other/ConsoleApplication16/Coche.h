#pragma once
#include "Vehiculo.h"
class Coche:public Vehiculo
{
private:
    string tipoCombustible;
public:
    Coche(string, string, int, string);
    void mostrarTipoCombustible();
};

