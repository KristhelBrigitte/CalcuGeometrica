
namespace Calculadora_Geometrica
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piramideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tetraedoRegularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octaedroRegularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prismaRectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortoedroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.figurasToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esferaToolStripMenuItem,
            this.piramideToolStripMenuItem,
            this.tetraedoRegularToolStripMenuItem,
            this.octaedroRegularToolStripMenuItem,
            this.cuboToolStripMenuItem,
            this.cilindroToolStripMenuItem,
            this.prismaRectoToolStripMenuItem,
            this.conoToolStripMenuItem,
            this.ortoedroToolStripMenuItem});
            this.figurasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // esferaToolStripMenuItem
            // 
            this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            this.esferaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esferaToolStripMenuItem.Text = "Esfera";
            this.esferaToolStripMenuItem.Click += new System.EventHandler(this.esferaToolStripMenuItem_Click);
            // 
            // piramideToolStripMenuItem
            // 
            this.piramideToolStripMenuItem.Name = "piramideToolStripMenuItem";
            this.piramideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.piramideToolStripMenuItem.Text = "Piramide";
            this.piramideToolStripMenuItem.Click += new System.EventHandler(this.piramideToolStripMenuItem_Click);
            // 
            // tetraedoRegularToolStripMenuItem
            // 
            this.tetraedoRegularToolStripMenuItem.Name = "tetraedoRegularToolStripMenuItem";
            this.tetraedoRegularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tetraedoRegularToolStripMenuItem.Text = "Tetraedo Regular";
            this.tetraedoRegularToolStripMenuItem.Click += new System.EventHandler(this.tetraedoRegularToolStripMenuItem_Click);
            // 
            // octaedroRegularToolStripMenuItem
            // 
            this.octaedroRegularToolStripMenuItem.Name = "octaedroRegularToolStripMenuItem";
            this.octaedroRegularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.octaedroRegularToolStripMenuItem.Text = "Octaedro Regular";
            this.octaedroRegularToolStripMenuItem.Click += new System.EventHandler(this.octaedroRegularToolStripMenuItem_Click);
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cuboToolStripMenuItem_Click);
            // 
            // cilindroToolStripMenuItem
            // 
            this.cilindroToolStripMenuItem.Name = "cilindroToolStripMenuItem";
            this.cilindroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cilindroToolStripMenuItem.Text = "Cilindro";
            this.cilindroToolStripMenuItem.Click += new System.EventHandler(this.cilindroToolStripMenuItem_Click);
            // 
            // prismaRectoToolStripMenuItem
            // 
            this.prismaRectoToolStripMenuItem.Name = "prismaRectoToolStripMenuItem";
            this.prismaRectoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prismaRectoToolStripMenuItem.Text = "Prisma Recto";
            this.prismaRectoToolStripMenuItem.Click += new System.EventHandler(this.prismaRectoToolStripMenuItem_Click);
            // 
            // conoToolStripMenuItem
            // 
            this.conoToolStripMenuItem.Name = "conoToolStripMenuItem";
            this.conoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conoToolStripMenuItem.Text = "Cono";
            this.conoToolStripMenuItem.Click += new System.EventHandler(this.conoToolStripMenuItem_Click);
            // 
            // ortoedroToolStripMenuItem
            // 
            this.ortoedroToolStripMenuItem.Name = "ortoedroToolStripMenuItem";
            this.ortoedroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ortoedroToolStripMenuItem.Text = "Ortoedro";
            this.ortoedroToolStripMenuItem.Click += new System.EventHandler(this.ortoedroToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calculadora Geometrica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piramideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tetraedoRegularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octaedroRegularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cilindroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prismaRectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortoedroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
    }
}

