#pragma once
#include <iostream>
#include <string>
using namespace std;
class Vehiculo
{
protected:
    string marca, modelo;
    int anio;
public:
    Vehiculo(string, string, int);
    void mostrarInformacion();
};

