using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacientes.ModelsBase;

namespace Pacientes.ModelsDerivados
{
    public class Medico : Persona
    {
        public Medico(string pnombre, string pEspecialidad) : base(pnombre)
        {
           Especialidad = pEspecialidad;
        }
        public string Especialidad { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + Especialidad;
        }
    }
}
