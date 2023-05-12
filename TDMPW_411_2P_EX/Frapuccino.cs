using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_411_2P_EX
{
    class Frapuccino : Producto
    {
        public Frapuccino()
        {
            nombreCompleto = "Bebida Mezclada\nFrappucino de\nChocolate con\njambul menta";
            nombre = "frappucino";
            imagen = "frapuccino.jpg";
            precio = 68.99;
        }
    }
}
