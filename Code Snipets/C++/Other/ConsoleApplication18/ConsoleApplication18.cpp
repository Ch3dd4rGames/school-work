// ConsoleApplication19.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.

#include <cstddef> // std::size_t
#include <iostream>
#include "Cuadrado.h"
#include "Triangulo.h"

void mostrar_figuras(Cuadrado* c_begin,
    Cuadrado* c_end,
    Triangulo* t_begin,
    Triangulo* t_end) {
    while (c_begin != c_end) {
        std::cout << "Figura:    " << c_begin->get_nombre() << std::endl;
        std::cout << "Perímetro: " << c_begin->get_perimetro() << std::endl;
        std::cout << "Area:      " << c_begin->area() << std::endl;
        ++c_begin;
    }
    while (t_begin != t_end) {
        std::cout << "Figura:    " << t_begin->get_nombre() << std::endl;
        std::cout << "Perímetro: " << t_begin->get_perimetro() << std::endl;
        std::cout << "Area:      " << t_begin->area() << std::endl;
        ++t_begin;
    }
}

int main() {
    constexpr std::size_t num_cuadrados {2};
    constexpr std::size_t num_triangulos {2};

    Cuadrado cuadrados[num_cuadrados]{
      std::move(Cuadrado{"Cuadrado 2", 2}),
      std::move(Cuadrado{"Cuadrado 3", 3})
    };

    Triangulo triangulos[num_triangulos]{
      std::move(Triangulo{"Triangulo 234", 2,3,4}),
      std::move(Triangulo{"Triangulo 456", 4,5,6})
    };

    mostrar_figuras(cuadrados, cuadrados + num_cuadrados,
        triangulos, triangulos + num_triangulos);
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
