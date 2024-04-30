#pragma once

class Rectangulo
{
private:
    int lado1, lado2;
public:
    //Constructor parámetros
    Rectangulo(int, int);
    const int getlado1();
    const int getlado2();
    //Constructor copia
    //Rectangulo(const Rectangulo& r);
    //Sobrecarga del operador asignación
    Rectangulo& operator = (const Rectangulo& c);
    //Sobrecarga del operador suma (+)
    Rectangulo& operator + (const Rectangulo& c);
}; 

