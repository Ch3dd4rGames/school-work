#include <iostream>
#include "Esfera.h"
using namespace std;

double Esfera::volumen(float r) const
{
    return 4 / 3 * 3.14 * r * r * r;
}

float Esfera::mover(float dx, float dy, float dz)
{
    return this->x + dx, this->y + dy, this->z + dz; //Suma las tres coordenadas por separado
}

void Esfera::informacion()
{
    cout << "Esfera" << endl;
}

bool Esfera::operator==(Esfera e) const
{
    if (e.x == this->x && e.y == this->y && e.z == this->z && e.r == this->r)
        return true;
    else
        return false;
}
