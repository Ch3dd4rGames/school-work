#include <iostream>
#include "Empleado.h"

Empleado::Empleado(string _nombre, int _ID, int _salario, int* _deducciones):nombre{ _nombre }, ID{ _ID }, salario{ _salario }, deducciones{ _deducciones } {}

void Empleado::mostrarDatos()
{
    cout << "Nombre: " << nombre << endl;
    cout << "ID: " << ID << endl;
    cout << "Salario: " << salario << endl;
}

void Empleado::calcularSalarioNeto()
{
    cout << "Salario neto: " << salario - *deducciones << endl;
}