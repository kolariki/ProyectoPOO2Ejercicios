using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Tablero.ModelsBase
{
   public abstract class Ficha
    {
        public string Nombre { get; set; }

        public string Direccion { get; set; }


        public virtual string Imprimir()
        {

            return Nombre + ", " + Direccion;
        }

    }
}
