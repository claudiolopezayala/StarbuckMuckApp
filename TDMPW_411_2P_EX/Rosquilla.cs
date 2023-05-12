using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDMPW_411_2P_EX
{
    class Rosquilla : Producto
    {
        public Rosquilla()
        {
            nombreCompleto = "Rosquilla simple";
            nombre = "rosquilla";
            imagen = "bakery.jpg";
            precio = 419.99;
        }
    }
}
