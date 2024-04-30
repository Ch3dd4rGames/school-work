#include <iostream>
#include "Empleado.h"
using namespace std;
class Gerente:public Empleado
{
private:
    int* bonificaciones;
public:
    void calcularBonificaciones();
};

