
namespace RestoDivisao
{
    partial class FrmDivisão
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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(12, 27);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(58, 13);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(76, 20);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(137, 20);
            this.txtDividendo.TabIndex = 1;
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(15, 68);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 2;
            this.lblDivisor.Text = "Divisor:";
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(76, 61);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(137, 20);
            this.txtDivisor.TabIndex = 3;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(106, 113);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(15, 181);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(79, 174);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(134, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // FrmDivisão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 220);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblDividendo);
            this.Name = "FrmDivisão";
            this.Text = "Mostrar o resto da divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

