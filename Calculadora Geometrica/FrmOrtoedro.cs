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
    public partial class FrmOrtoedro : Form
    {
        Global global = new Global();
        public FrmOrtoedro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Ortoedro orto = new Ortoedro();
            orto.Altura = double.Parse(txtAltura.Text);
            orto.Base1 = double.Parse(txtBase1.Text);
            orto.Base2 = double.Parse(txtBase2.Text);
            txtArea.Text = orto.CalcularArea().ToString();
            txtVol.Text=orto.CalcularVolumen().ToString();
            global.agregarRegistro(orto);
        }
    }
}
