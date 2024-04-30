#pragma once
#ifndef FIGURA_H
#define FIGURA_H

#include <cstddef> // std::size_t
#include <string>

class Figura {
public:
    Figura() = delete;
    Figura(const Figura&) = default;
    Figura(Figura&&) = default;
    Figura& operator=(const Figura&) = default;
    Figura& operator=(Figura&&) = default;
    ~Figura() = default;

    Figura(std::string, std::size_t);
    Figura(std::string nombre, std::size_t lado1, std::size_t lado2, std::size_t lado3);
    std::string get_nombre() const;
    std::size_t get_perimetro() const;
    virtual double area() const;
protected:
    std::string nombre;
    std::size_t perimetro;
    std::size_t lado;
    std::size_t lado[3];
};

#endif

