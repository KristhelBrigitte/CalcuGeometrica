﻿using System;
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
    public partial class FrmTetraedro : Form
    {
        Global global = new Global();
        public FrmTetraedro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            TetraedoRegular tetra = new TetraedoRegular();
            tetra.Lado = double.Parse(txtLado.Text);
            txtArea.Text = tetra.CalcularArea().ToString();
            txtVolumen.Text = tetra.CalcularVolumen().ToString();
            global.agregarRegistro(tetra);
       
        }
    }
}
