using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAnimales.Animales;
using ProyectoAnimales.Entidades;

namespace WindowsAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(21, 12, 14);

            MessageBox.Show(leon.Imprimir());
            MessageBox.Show(leon.ImprimirComida());
        }

        private void btnLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(12, 12, 1);

            MessageBox.Show(loro.Imprimir());
            MessageBox.Show(loro.ImprimirComida());
        }

        private void btnConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(20, 10, 3);

            MessageBox.Show(conejo.Imprimir());
            MessageBox.Show(conejo.ImprimirComida());
        }
    }
}
