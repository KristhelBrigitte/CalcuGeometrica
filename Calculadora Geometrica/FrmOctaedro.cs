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
    public partial class FrmOctaedro : Form
    {
        Global global = new Global();
        public FrmOctaedro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            OctaedroRegular octa = new OctaedroRegular();
            octa.Lado = double.Parse(txtLado.Text);
            txtArea.Text = octa.CalcularArea().ToString();
            txtVol.Text = octa.CalcularVolumen().ToString();
            global.agregarRegistro(octa);

        }

      
    }
}
