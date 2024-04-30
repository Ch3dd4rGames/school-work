#pragma once
#include "Circulo.h"
class Esfera : public Circulo
{
public:
    Esfera::Circulo override;
    double volumen(float) const;
    float mover(float, float, float);
    void informacion() override;
    bool operator==(Esfera) const;
private:
    float z;
};

