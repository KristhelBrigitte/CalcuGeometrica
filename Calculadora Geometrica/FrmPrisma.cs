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
            PrismaRecto pris = new PrismaRecto();
            pris.LadoBase = double.Parse(txtLadoB.Text);
            pris.Altura = double.Parse(txtAltura.Text);
            pris.Apotema = double.Parse(txtAp.Text);
            pris.CantidadLados = int.Parse(txtLados.Text);
            txtArea.Text = pris.CalcularArea().ToString();

            txtVol.Text = pris.CalcularVolumen().ToString();
            global.agregarRegistro(pris);

        }
    }
}
