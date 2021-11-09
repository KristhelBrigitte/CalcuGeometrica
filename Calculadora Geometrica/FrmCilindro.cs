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
    public partial class FrmCilindro : Form
    {
        Global global = new Global();
        public FrmCilindro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Cilindro cil = new Cilindro();
            cil.setAltura(double.Parse(txtAltura.Text));
            cil.setRadio(double.Parse(txtRadio.Text));

            txtArea.Text = cil.CalcularArea().ToString();
            txtVol.Text = cil.CalcularVolumen().ToString();
            global.agregarRegistro(cil);
        }



    }
}
