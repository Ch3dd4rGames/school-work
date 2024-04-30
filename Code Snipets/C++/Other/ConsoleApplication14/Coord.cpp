#include "Coord.h"

Coord::Coord(int x, int y) : x{x}, y{y} {}
Coord::Coord(const Coord& c) : x{c.x}, y{c.y} {}
Coord& Coord::operator=(const Coord& c) 
{
    x = c.get_x();
    y = c.get_y();
    return *this;
}
int Coord::get_x() const {return x;}
int Coord::get_y() const {return y;}
Coord& Coord::set(int x, int y) 
{
    this->x = x;
    this->y = y;
    return *this;
}

bool Coord::operator==(Coord c) const 
{
    if (c.x == this->x && c.y == this->y)
        return true;
    else
        return false;
}
bool Coord::operator!=(Coord c) const 
{
    if (c.x != this->x || c.y != this->y)
        return true;
    else
        return false;
}

bool Coord::operator<(Coord c) const 
{
    if (c.x < this->x && c.y < this->y)
        return true;
    else
        return false;
}

bool Coord::operator<=(Coord c) const 
{
    if (c.x <= this->x && c.y <= this->y)
        return true;
    else
        return false;
}

bool Coord::operator>(Coord c) const 
{
    if (c.x > this->x && c.y > this->y)
        return true;
    else
        return false;
}

bool Coord::operator>=(Coord c) const 
{
    if (c.x >= this->x && c.y >= this->y)
        return true;
    else
        return false;
}

Coord& Coord::operator+=(Coord c) 
{
    x += c.get_x();
    y += c.get_y();
    return *this;
}

Coord& Coord::operator-=(Coord c) 
{
    x -= c.get_x();
    y -= c.get_y();
    return *this;
}

Coord Coord::operator+(Coord c) const 
{
    return *(new Coord(this->x + c.x, this->y + c.y));
}

Coord Coord::operator+(int i) const 
{
    return *(new Coord(this->x + i, this->y + i));
}

Coord Coord::operator-(Coord c) const 
{
    return *(new Coord(this->x - c.x, this->y - c.y));
}

Coord Coord::operator-(int i) const 
{
    return *(new Coord(this->x - i, this->y - i));
}
