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
    public partial class FrmPrincipal : Form
    {
        FrmEsfera esferas;
        FrmPiramide piramides;
        FrmTetraedro tetra;
        FrmOctaedro octa;
        FrmCubo cub;
        FrmCilindro cil;
        FrmPrisma pris;
        FrmCono cono;
        FrmOrtoedro orto;
        FrmHistorial his;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (esferas == null)
            {
               esferas = new FrmEsfera();
               esferas.MdiParent = this;
               esferas.FormClosed += new FormClosedEventHandler(cerrar);
               esferas.Show();
            }
            else
            {
                esferas.Activate();
            }
        }

        private void cerrar(object sender, FormClosedEventArgs e)
        {
            esferas = null;piramides = null;tetra = null;octa = null;
            cil = null; cub = null;pris = null; his = null;
        }

        private void piramideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (piramides == null)
            {
                piramides = new FrmPiramide();
                piramides.MdiParent = this;
                piramides.FormClosed += new FormClosedEventHandler(cerrar);
                piramides.Show();
            }
            else
            {
                piramides.Activate();
            }
        }

        private void tetraedoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tetra == null)
            {
                tetra = new FrmTetraedro();
                tetra.MdiParent = this;
                tetra.FormClosed += new FormClosedEventHandler(cerrar);
                tetra.Show();
            }
            else
            {
                tetra.Activate();
            }
        }

        private void octaedroRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (octa == null)
            {
                octa = new FrmOctaedro();
                octa.MdiParent = this;
                octa.FormClosed += new FormClosedEventHandler(cerrar);
                octa.Show(); 
            }
            else
            {
                octa.Activate();
            }

        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cub == null)
            {
                cub = new FrmCubo();
                cub.MdiParent = this;
                cub.FormClosed += new FormClosedEventHandler(cerrar);
                cub.Show();
            }
            else
            {
                cub.Activate();
            }

        }

        private void cilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cil== null)
            {
                cil = new FrmCilindro();
                cil.MdiParent = this;
                cil.FormClosed += new FormClosedEventHandler(cerrar);
                cil.Show();
            }
            else
            {
                cil.Activate();
            }
        }

        private void prismaRectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pris == null)
            {
                pris= new FrmPrisma();
                pris.MdiParent = this;
                pris.FormClosed += new FormClosedEventHandler(cerrar);
                pris.Show();
            }
            else
            {
                pris.Activate();
            }
        }

        private void conoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cono == null)
            {
                cono= new FrmCono();
                cono.MdiParent = this;
                cono.FormClosed += new FormClosedEventHandler(cerrar);
                cono.Show();
            }
            else
            {
                cono.Activate();
            }
        }

        private void ortoedroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orto == null)
            {
                orto = new FrmOrtoedro();
                orto.MdiParent = this;
                orto.FormClosed += new FormClosedEventHandler(cerrar);
                orto.Show();
            }
            else
            {
                orto.Activate();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (his == null)
            {
                his = new FrmHistorial();
                his.MdiParent = this;
                his.FormClosed += new FormClosedEventHandler(cerrar);
                his.Show();
            }
            else
            {
                his.Activate();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
