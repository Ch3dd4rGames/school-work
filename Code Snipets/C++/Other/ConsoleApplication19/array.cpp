/*
#include "array.h"
template <typename T>
array<T>::array(unsigned n) : v_{ 0 }, n_{ n }
{
    try
    {
        v_ = new T[n];
    }
    catch (std::bad_alloc&) //Si no se puede reservar memoria
    {
        n_{ 0 }; //Se hace el tama�o igual a 0
        throw; //Se relanza la excepci�n
    }
}
template <typename T>
array<T>::~array()
{
    if (v_)delete[]v_; //Liberaci�n de memoria
}
template <typename T>
T& array<T>::operator[](unsigned i)
{
    if (i >= n:)
}
*/
