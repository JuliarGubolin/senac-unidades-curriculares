
namespace MatriculaAluno
{
    partial class FrmMatricula
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
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblHoje = new System.Windows.Forms.Label();
            this.lblIdadeAtual = new System.Windows.Forms.Label();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMostraCategoria = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Location = new System.Drawing.Point(8, 70);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(103, 13);
            this.lblAnoNasc.TabIndex = 2;
            this.lblAnoNasc.Text = "Ano de Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(117, 64);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(101, 20);
            this.dtpNascimento.TabIndex = 2;
            // 
            // lblHoje
            // 
            this.lblHoje.AutoSize = true;
            this.lblHoje.Location = new System.Drawing.Point(257, 71);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(0, 13);
            this.lblHoje.TabIndex = 0;
            // 
            // lblIdadeAtual
            // 
            this.lblIdadeAtual.AutoSize = true;
            this.lblIdadeAtual.Location = new System.Drawing.Point(114, 103);
            this.lblIdadeAtual.Name = "lblIdadeAtual";
            this.lblIdadeAtual.Size = new System.Drawing.Size(0, 13);
            this.lblIdadeAtual.TabIndex = 0;
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Location = new System.Drawing.Point(12, 159);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(111, 40);
            this.btnIdentificar.TabIndex = 3;
            this.btnIdentificar.Text = "Identificar Categoria";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(139, 173);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMostraCategoria
            // 
            this.lblMostraCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMostraCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraCategoria.Location = new System.Drawing.Point(212, 172);
            this.lblMostraCategoria.Name = "lblMostraCategoria";
            this.lblMostraCategoria.Size = new System.Drawing.Size(186, 80);
            this.lblMostraCategoria.TabIndex = 0;
            this.lblMostraCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(356, 342);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 377);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMostraCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.lblIdadeAtual);
            this.Controls.Add(this.lblHoje);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblAnoNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMatricula";
            this.Text = "Matrícula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblHoje;
        private System.Windows.Forms.Label lblIdadeAtual;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMostraCategoria;
        private System.Windows.Forms.Button btnSair;
    }
}

