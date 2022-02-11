
namespace IMC_atividade
{
    partial class FrmCalculoPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(33, 41);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(64, 18);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(119, 39);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(193, 23);
            this.txtAltura.TabIndex = 1;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtFeminino);
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSexo.Location = new System.Drawing.Point(356, 12);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(317, 100);
            this.gpbSexo.TabIndex = 2;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(15, 61);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(76, 17);
            this.rbtFeminino.TabIndex = 1;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            this.rbtFeminino.CheckedChanged += new System.EventHandler(this.rbtFeminino_CheckedChanged);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(15, 27);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(80, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.rbtMasculino_CheckedChanged);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.Location = new System.Drawing.Point(288, 161);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(74, 16);
            this.lblPesoIdeal.TabIndex = 3;
            this.lblPesoIdeal.Text = "Peso ideal";
            // 
            // lblPeso
            // 
            this.lblPeso.BackColor = System.Drawing.Color.Yellow;
            this.lblPeso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(251, 194);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(160, 61);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalculoPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 321);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Name = "FrmCalculoPesoIdeal";
            this.Text = "Cálculo do IMC (Índice de Massa Corpórea)";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.Label lblPeso;
    }
}

