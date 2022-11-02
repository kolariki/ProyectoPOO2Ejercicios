using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnimales.Animales
{
    public abstract class Animal
    {
       

        private int Edad { get; }
        private int Altura { get; }
        private int Peso { get; }

        public Animal(int Edad, int Altura, int Peso)
        {

            this.Edad =Edad;
            this.Altura = Altura;
            this.Peso = Peso;
        }
        public virtual string Imprimir()
        {
            return  "Edad:" + Edad + "Altura: " + Altura + "Peso: "+ Peso;
        }
        public abstract string ImprimirComida();
    }

    }
