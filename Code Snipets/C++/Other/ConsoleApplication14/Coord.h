#pragma once

class Coord
{
public:
    explicit Coord(int = 0, int = 0); //Constructor por defecto, (int), e (int, int).                         
    Coord(const Coord&); //Constructor de copia
    Coord& operator = (const Coord&); //Asignación  de copia
    ~Coord() = default; //Destructor (creado por defecto)
    int get_x() const; //getter
    int get_y() const; //getter
    Coord& set(const int = 0, const int = 0); //setter

    //Más operadores
    bool operator==(Coord) const; //Podría pasarse por const-ref
    bool operator!=(Coord c) const;
    bool operator<(Coord c) const;
    bool operator<=(Coord c) const;
    bool operator>(Coord c) const;
    bool operator>=(Coord c) const;
    Coord& operator+=(Coord);
    Coord& operator-=(Coord);
    Coord operator+(Coord) const;
    Coord operator+(int) const;
    Coord operator-(Coord) const;
    Coord operator-(int i) const;
private:
    int x, y;
};



