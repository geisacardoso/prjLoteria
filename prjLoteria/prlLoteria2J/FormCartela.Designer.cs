namespace prlLoteria2J
{
    partial class FormCartela
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnInferior = new System.Windows.Forms.Panel();
            this.btnGerarCartela = new System.Windows.Forms.Button();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbLotoFacil = new System.Windows.Forms.RadioButton();
            this.rbLotoMania = new System.Windows.Forms.RadioButton();
            this.rbMega = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCartelas = new System.Windows.Forms.Panel();
            this.pnSuperior.SuspendLayout();
            this.pnInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(882, 42);
            this.pnSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(166)))), ((int)(((byte)(145)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERADOR DE CARTELAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(166)))), ((int)(((byte)(145)))));
            this.pnInferior.Controls.Add(this.btnGerarCartela);
            this.pnInferior.Controls.Add(this.rbQuina);
            this.pnInferior.Controls.Add(this.rbLotoFacil);
            this.pnInferior.Controls.Add(this.rbLotoMania);
            this.pnInferior.Controls.Add(this.rbMega);
            this.pnInferior.Controls.Add(this.label2);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInferior.Location = new System.Drawing.Point(0, 458);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(882, 95);
            this.pnInferior.TabIndex = 1;
            // 
            // btnGerarCartela
            // 
            this.btnGerarCartela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(145)))), ((int)(((byte)(132)))));
            this.btnGerarCartela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarCartela.Location = new System.Drawing.Point(634, 11);
            this.btnGerarCartela.Name = "btnGerarCartela";
            this.btnGerarCartela.Size = new System.Drawing.Size(236, 73);
            this.btnGerarCartela.TabIndex = 5;
            this.btnGerarCartela.Text = "GERAR CARTELA";
            this.btnGerarCartela.UseVisualStyleBackColor = false;
            this.btnGerarCartela.Click += new System.EventHandler(this.btnGerarCartela_Click);
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Location = new System.Drawing.Point(500, 45);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(71, 18);
            this.rbQuina.TabIndex = 4;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rbLotoFacil
            // 
            this.rbLotoFacil.AutoSize = true;
            this.rbLotoFacil.Location = new System.Drawing.Point(338, 45);
            this.rbLotoFacil.Name = "rbLotoFacil";
            this.rbLotoFacil.Size = new System.Drawing.Size(103, 18);
            this.rbLotoFacil.TabIndex = 3;
            this.rbLotoFacil.Text = "LOTOFACIL";
            this.rbLotoFacil.UseVisualStyleBackColor = true;
            // 
            // rbLotoMania
            // 
            this.rbLotoMania.AutoSize = true;
            this.rbLotoMania.Location = new System.Drawing.Point(179, 45);
            this.rbLotoMania.Name = "rbLotoMania";
            this.rbLotoMania.Size = new System.Drawing.Size(108, 18);
            this.rbLotoMania.TabIndex = 2;
            this.rbLotoMania.Text = "LOTOMANIA";
            this.rbLotoMania.UseVisualStyleBackColor = true;
            // 
            // rbMega
            // 
            this.rbMega.AutoSize = true;
            this.rbMega.Checked = true;
            this.rbMega.Location = new System.Drawing.Point(24, 45);
            this.rbMega.Name = "rbMega";
            this.rbMega.Size = new System.Drawing.Size(99, 18);
            this.rbMega.TabIndex = 1;
            this.rbMega.TabStop = true;
            this.rbMega.Text = "MEGASENA";
            this.rbMega.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "TIPOS DE CARTELA";
            // 
            // pnCartelas
            // 
            this.pnCartelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.pnCartelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCartelas.Location = new System.Drawing.Point(0, 42);
            this.pnCartelas.Name = "pnCartelas";
            this.pnCartelas.Size = new System.Drawing.Size(882, 416);
            this.pnCartelas.TabIndex = 2;
            // 
            // FormCartela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pnCartelas);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormCartela";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERADOR DE CARTELAS";
            this.pnSuperior.ResumeLayout(false);
            this.pnInferior.ResumeLayout(false);
            this.pnInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.Button btnGerarCartela;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotoFacil;
        private System.Windows.Forms.RadioButton rbLotoMania;
        private System.Windows.Forms.RadioButton rbMega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnCartelas;
    }
}

