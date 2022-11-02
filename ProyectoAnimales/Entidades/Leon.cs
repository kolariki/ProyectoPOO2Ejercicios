using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAnimales.Animales;

namespace ProyectoAnimales.Entidades
{
    public class Leon : Animal
    {

        public Leon(int Edad, int Altura, int Peso) : base(Edad, Altura, Peso)
        {

        }
        public override string Imprimir()
        {
            return base.Imprimir();
        }
        public override string ImprimirComida()
        {
            return "El leon es carnivoro";
        }

    }
}

