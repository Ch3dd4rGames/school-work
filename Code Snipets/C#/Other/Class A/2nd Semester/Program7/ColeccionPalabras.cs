using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class ColeccionPalabras
    {
        private static string[] FrutasHortalizas =
        {
            "aceituna",
            "acelga",
            "aguacate",
            "ajo",
            "albahaca",
            "alcachofa",
            "almendra",
            "apio",
            "arandano",
            "arveja",
            "banana",
            "berenjena",
            "brocoli",
            "cebolla",
            "cereza",
            "choclo",
            "ciruela",
            "coco",
            "coliflor",
            "durazno",
            "endibia",
            "esparrago",
            "espinaca",
            "frambuesa",
            "fresa",
            "frijol",
            "granada",
            "guayaba",
            "guinda",
            "guisante",
            "higo",
            "jengibre",
            "kiwi",
            "lechuga",
            "limon",
            "mandarina",
            "mani",
            "manzana",
            "melon",
            "mora",
            "naranja",
            "nispero",
            "nuez",
            "papa",
            "pepino",
            "pera",
            "pimiento",
            "platano",
            "pomelo",
            "puerro",
            "rabano",
            "sandia",
            "tomate",
            "uva",
            "zanahoria",
            "zapallo"
        };

        public static string PalabraAleatoria()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, FrutasHortalizas.Length);
            return FrutasHortalizas[i];
        }
    }
}
