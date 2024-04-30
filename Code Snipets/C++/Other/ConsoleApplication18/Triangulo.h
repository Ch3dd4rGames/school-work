#pragma once
#include "Figura.h"
#ifndef TRIANGULO_H
#define TRIANGULO_H

#include <cstddef> // std::size_t
#include <string>

class Triangulo : public Figura {
public:
    Triangulo::Figura override;
private:
    std::size_t lado[3];
};

#endif

