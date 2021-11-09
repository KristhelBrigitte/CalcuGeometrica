using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Calculadora_Geometrica
{
    public partial class FrmHistorial : Form
    {
        Global global = new Global();
        public FrmHistorial()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ArrayList registros = global.getArrayLis();

            foreach (Figura fig in registros)
            {
                lvHistorial.Items.Add(fig.ToString());
            }
        }
    }
}
