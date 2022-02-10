
namespace LoopFor
{
    partial class FrmPrincipal
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.btnRepetir = new System.Windows.Forms.Button();
            this.cbbRepetir = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Digite seu nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Location = new System.Drawing.Point(12, 57);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(64, 13);
            this.lblRepetir.TabIndex = 2;
            this.lblRepetir.Text = "Repetições:";
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(114, 54);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.Size = new System.Drawing.Size(100, 20);
            this.txtRepetir.TabIndex = 3;
            // 
            // btnRepetir
            // 
            this.btnRepetir.Location = new System.Drawing.Point(238, 52);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(78, 23);
            this.btnRepetir.TabIndex = 4;
            this.btnRepetir.Text = "Repetir";
            this.btnRepetir.UseVisualStyleBackColor = true;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // cbbRepetir
            // 
            this.cbbRepetir.FormattingEnabled = true;
            this.cbbRepetir.Location = new System.Drawing.Point(64, 108);
            this.cbbRepetir.Name = "cbbRepetir";
            this.cbbRepetir.Size = new System.Drawing.Size(199, 21);
            this.cbbRepetir.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(141, 193);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 176);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cbbRepetir);
            this.Controls.Add(this.btnRepetir);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRepetir;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.Button btnRepetir;
        private System.Windows.Forms.ComboBox cbbRepetir;
        private System.Windows.Forms.Label lblResultado;
    }
}

