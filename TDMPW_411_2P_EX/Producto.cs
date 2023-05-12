using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_411_2P_EX
{
    class Producto
    {
        protected string nombreCompleto;
        protected string imagen;
        protected string nombre;
        protected double precio;

        public string getNombreCompleto () { return nombreCompleto; }
        public string getImagen() { return imagen; }
        public double getPrecio() {  return precio; }
        public string getNombre() { return nombre; }
    }
}
