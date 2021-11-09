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
    public partial class FrmEsfera : Form
    {
        Global global=new Global();
        public FrmEsfera()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Esfera esfera1 = new Esfera();
            esfera1.Radio = (double.Parse(txtRadio.Text));
            txtArea.Text=esfera1.CalcularArea().ToString();
            txtVol.Text= esfera1.CalcularVolumen().ToString();
            global.agregarRegistro(esfera1);
        }
    }
}
