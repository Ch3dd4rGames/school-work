#pragma once

class Punto2D
{
private:
    int x;
    int y;
public:
    //Constructor con parámetros
    Punto2D(int = 0, int = 0);
    //Metodos get para obtener el valor
    const int getx();
    const int gety();
    //Metodos set para modificar el valor
    //x_ es el nuevo valor para el atributo x
    void setx(int x_);
    void sety(int y_);
    //Destructor. Elimina la memoria dinámica que se necesita al crear el objeto. Libera recursos
    ~Punto2D() = default;
};