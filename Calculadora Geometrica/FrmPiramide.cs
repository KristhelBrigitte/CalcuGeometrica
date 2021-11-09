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
    public partial class FrmPiramide : Form
    {
        Global global=new Global();
        public FrmPiramide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Piramide pira = new Piramide();
            pira.Altura = double.Parse(txtBase.Text);
            pira.LadoBase = double.Parse(txtAltura.Text);
            txtArea.Text = pira.CalcularArea().ToString();
            txtVolumen.Text = pira.CalcularVolumen().ToString();
            global.agregarRegistro(pira);
        }
    }
}
