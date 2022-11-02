using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes.ModelsBase
{
    public class Persona
    {
         public Persona (string pnombre)
        {
            Nombre = pnombre;
        }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
