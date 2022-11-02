using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPOO2.Models.Derivados;
using LibAjedrez.Tablero.Models;
using LibAjedrez.Tablero.ModelsBase;


namespace WindowsAfinar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnAfinar_Click(object sender, EventArgs e)
        {
            Guitarra instrumento1 = new Guitarra();

            MessageBox.Show(instrumento1.Afinar("Gaby", "Afinando", "Guitarra"));

            Violin instrumento2 = new Violin();

            MessageBox.Show(instrumento2.Afinar("Gaby", "Afinando", "Violin"));

            Piano instrumento3 = new Piano();

            MessageBox.Show(instrumento3.Afinar("Gaby", "Afinando", "Piano"));

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Peon ficha1 = new Peon()
            {
                Nombre = "Peon",
                Direccion = "Diagonal de uno en uno"
                
            };

            Caballo ficha2 = new Caballo()
            {
                Nombre = "Caballo",
                Direccion = "En L"

            };

            Torre ficha3 = new Torre()
            {
                Nombre = "Torre",
                Direccion = "Diagonal"

            };

            MessageBox.Show(ficha1.Imprimir());
            MessageBox.Show(ficha2.Imprimir());
            MessageBox.Show(ficha3.Imprimir());



        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {

        }
    }
}

