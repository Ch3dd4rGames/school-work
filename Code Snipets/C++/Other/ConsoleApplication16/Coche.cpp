#include "Coche.h"

Coche::Coche(string _marca, string _modelo, int _anio, string _tipoCombustible):Vehiculo(_marca, _modelo, _anio), tipoCombustible{ _tipoCombustible } {}

void Coche::mostrarTipoCombustible()
{
    cout << "Tipo de combustible: " << tipoCombustible << endl;
}

