namespace CargarGuardar_e_ComboBoxAnidado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUF = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(304, 53);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 0;
            this.lblUF.Text = "UF:";
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Location = new System.Drawing.Point(384, 45);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(144, 21);
            this.cbxUF.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 48);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(135, 45);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 3;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(573, 53);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 4;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(666, 48);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(121, 21);
            this.cbxMunicipio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 146);
            this.Controls.Add(this.cbxMunicipio);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.lblUF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cbxMunicipio;
    }
}

