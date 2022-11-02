using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacientes.ModelsBase;

namespace Pacientes.ModelsDerivados
{
    public class Paciente : Persona 
    {
        public Paciente(string pnombre, string pLegajop) : base(pnombre)
        {
            Legajo = pLegajop;
        }
        public string Legajo { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + Legajo;
        }
    }
}
