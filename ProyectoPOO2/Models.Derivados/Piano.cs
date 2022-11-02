using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPOO2.Models.Base;

namespace ProyectoPOO2.Models.Derivados
{
    public class Piano : Instrumentos
    {
        public override string Afinar(string usuario, string msj, string Instrumento)
        {
            
            return " Afinando Piano";
        }
    }
}

