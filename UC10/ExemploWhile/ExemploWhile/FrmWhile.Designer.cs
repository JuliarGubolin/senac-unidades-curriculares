
namespace ExemploWhile
{
    partial class FrmWhile
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
            this.btnRepetir = new System.Windows.Forms.Button();
            this.cbbRepetir = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRepetir
            // 
            this.btnRepetir.Location = new System.Drawing.Point(101, 35);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(75, 23);
            this.btnRepetir.TabIndex = 0;
            this.btnRepetir.Text = "Repetir";
            this.btnRepetir.UseVisualStyleBackColor = true;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // cbbRepetir
            // 
            this.cbbRepetir.FormattingEnabled = true;
            this.cbbRepetir.Location = new System.Drawing.Point(80, 80);
            this.cbbRepetir.Name = "cbbRepetir";
            this.cbbRepetir.Size = new System.Drawing.Size(121, 21);
            this.cbbRepetir.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(133, 131);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;
            // 
            // FrmWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 190);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cbbRepetir);
            this.Controls.Add(this.btnRepetir);
            this.Name = "FrmWhile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo Repetição While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepetir;
        private System.Windows.Forms.ComboBox cbbRepetir;
        private System.Windows.Forms.Label lblResultado;
    }
}

