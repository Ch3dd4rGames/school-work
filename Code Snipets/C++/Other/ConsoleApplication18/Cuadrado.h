#pragma once
#include "Figura.h"
#ifndef CUADRADO_H
#define CUADRADO_H

#include <cstddef> // std::size_t
#include <string>

class Cuadrado : public Figura {
public:
    Cuadrado::Figura override;
private:
    std::size_t lado;
};

#endif

