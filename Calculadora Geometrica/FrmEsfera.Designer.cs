
namespace Calculadora_Geometrica
{
    partial class FrmEsfera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(60, 89);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(60, 186);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 2;
            // 
            // txtVol
            // 
            this.txtVol.Location = new System.Drawing.Point(60, 251);
            this.txtVol.Name = "txtVol";
            this.txtVol.Size = new System.Drawing.Size(100, 20);
            this.txtVol.TabIndex = 3;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(57, 73);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(115, 13);
            this.lblRadio.TabIndex = 4;
            this.lblRadio.Text = "Por favor digite el radio";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(57, 170);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area=";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(57, 235);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(54, 13);
            this.lblVolumen.TabIndex = 6;
            this.lblVolumen.Text = "Volumen=";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(60, 115);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmEsfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(311, 392);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtVol);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadio);
            this.Name = "FrmEsfera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEsfera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtVol;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Button btnCalcular;
    }
}