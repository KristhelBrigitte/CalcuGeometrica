using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Geometrica
{
    public partial class FrmPrisma : Form
    {
        Global global = new Global();
        public FrmPrisma()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            PrismaRecto pris = new PrismaRecto(double.Parse(txtAltura.Text), double.Parse(txtLadoB.Text), double.Parse(txtAp.Text),int.Parse(txtLados.Text));
            txtArea.Text = pris.CalcularArea().ToString();
            txtVol.Text = pris.CalcularVolumen().ToString();
          //  global.agregarRegistro("Figura='Prisma' Altura = " + txtAltura.Text + " Lado base=" + txtLadoB.Text + "Apotema= "+ txtAp.Text +" # Lados="+ txtLados.Text +" Area = " + txtArea.Text + " Volumen=" + txtVol.Text);

        }
    }
}
