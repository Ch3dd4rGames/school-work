#include <iostream>
using namespace std;
class Empleado
{
protected:
    string nombre;
    int ID, salario;
    int* deducciones;
public:
    Empleado(string, int, int, int*);
    void mostrarDatos();
    void calcularSalarioNeto();
};

