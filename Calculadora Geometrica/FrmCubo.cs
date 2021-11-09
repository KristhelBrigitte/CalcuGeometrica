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
    public partial class FrmCubo : Form
    {
        Global global = new Global();
        public FrmCubo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Cubo cub = new Cubo();
            cub.Lado = double.Parse(txtLado.Text);
            txtArea.Text = cub.CalcularArea().ToString();
            txtVol.Text = cub.CalcularVolumen().ToString();
            global.agregarRegistro(cub);
          
        }
    }
}
