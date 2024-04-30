#include "Urna.h"

int Urna::SacarBola(int bombo[100], int bolas, int bola)
{
    int vuelta = *(bombo + bola - 1);
    for (int i = bola - 1; i < bolas; i++)
    {
        *(bombo + i) = *(bombo + i + 1);
    }
    return vuelta;
}
void Urna::MeterBola(int bombo[100], int bolas, int bola)
{
    for (int i = bolas - 1; i > bola - 1; i--)
    {
        *(bombo + i) = *(bombo + i - 1);
    }
     *(bombo + bola - 1) = bola;
}
void Urna::MeterTodasLasBolas(int bombo[100])
{
    for (int i = 0; i < 100; i++)
        *(bombo + i) = i + 1;
}
