
namespace EstruturaForEach_Vetor
{
    partial class FrmTurismo
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
            this.lblLugares = new System.Windows.Forms.Label();
            this.txtVisitar = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblLocais = new System.Windows.Forms.Label();
            this.ltbLocais = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLugares
            // 
            this.lblLugares.AutoSize = true;
            this.lblLugares.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugares.Location = new System.Drawing.Point(9, 43);
            this.lblLugares.Name = "lblLugares";
            this.lblLugares.Size = new System.Drawing.Size(197, 13);
            this.lblLugares.TabIndex = 0;
            this.lblLugares.Text = "5 lugares que gostaria de visitar:";
            // 
            // txtVisitar
            // 
            this.txtVisitar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitar.Location = new System.Drawing.Point(12, 78);
            this.txtVisitar.Name = "txtVisitar";
            this.txtVisitar.Size = new System.Drawing.Size(188, 21);
            this.txtVisitar.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdicionar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(65, 105);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 29);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar a lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblLocais
            // 
            this.lblLocais.AutoSize = true;
            this.lblLocais.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocais.Location = new System.Drawing.Point(279, 43);
            this.lblLocais.Name = "lblLocais";
            this.lblLocais.Size = new System.Drawing.Size(160, 13);
            this.lblLocais.TabIndex = 4;
            this.lblLocais.Text = "Lista dos locais preferidos:";
            // 
            // ltbLocais
            // 
            this.ltbLocais.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbLocais.FormattingEnabled = true;
            this.ltbLocais.Location = new System.Drawing.Point(282, 62);
            this.ltbLocais.Name = "ltbLocais";
            this.ltbLocais.Size = new System.Drawing.Size(211, 238);
            this.ltbLocais.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(282, 306);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(211, 33);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar a lista";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.IndianRed;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(12, 310);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 29);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmTurismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 354);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.ltbLocais);
            this.Controls.Add(this.lblLocais);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtVisitar);
            this.Controls.Add(this.lblLugares);
            this.Name = "FrmTurismo";
            this.Text = "Locais para Visitar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLugares;
        private System.Windows.Forms.TextBox txtVisitar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLocais;
        private System.Windows.Forms.ListBox ltbLocais;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
    }
}

