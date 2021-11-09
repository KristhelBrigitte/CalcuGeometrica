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
    public partial class FrmCono : Form
    {
        Global global = new Global();
        public FrmCono()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Cono cono = new Cono();
            cono.setRadio(double.Parse(txtRadio.Text));
            cono.setAltura(double.Parse(txtAltura.Text));
            cono.setGeneratriz(double.Parse(txtGen.Text));

            txtArea.Text = cono.CalcularArea().ToString();
            txtVolumen.Text = cono.CalcularVolumen().ToString();
            global.agregarRegistro(cono);
        }
    }
}
