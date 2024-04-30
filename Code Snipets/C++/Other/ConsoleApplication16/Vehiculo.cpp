#include <iostream>
#include "Vehiculo.h"

Vehiculo::Vehiculo(string _marca, string _modelo, int _anio):marca{ _marca }, modelo{ _modelo }, anio{ _anio } {}

void Vehiculo::mostrarInformacion()
{
    cout << "Marca: " << marca << endl;
    cout << "Modelo: " << modelo << endl;
    cout << "Año: " << anio << endl;
}

