#pragma once
class Circulo
{
public:
    Circulo();
    Circulo(float, float, float);
    Circulo(float, float, float, float);
    double area(float) const;
    float mover(float, float);
    virtual void informacion();
    bool operator==(Circulo) const;
protected:
    float x;
    float y;
    float r;
};

