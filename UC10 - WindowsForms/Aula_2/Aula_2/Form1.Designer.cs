
namespace Aula_2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNome = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.rtbInfos = new System.Windows.Forms.RichTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Maroon;
            this.txtNome.Location = new System.Drawing.Point(216, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 27);
            this.txtNome.TabIndex = 0;
            // 
            // btnNome
            // 
            this.btnNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNome.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnNome.Image = ((System.Drawing.Image)(resources.GetObject("btnNome.Image")));
            this.btnNome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNome.Location = new System.Drawing.Point(76, 241);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(121, 59);
            this.btnNome.TabIndex = 1;
            this.btnNome.Text = "Confirmar";
            this.btnNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNome.UseVisualStyleBackColor = false;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(24, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(150, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Digite seu nome:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Chocolate;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(268, 241);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 59);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(22, 99);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(185, 18);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Digite seu endereço: ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEndereco.Location = new System.Drawing.Point(216, 90);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(219, 27);
            this.txtEndereco.TabIndex = 5;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(24, 171);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(156, 18);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Digite sua idade: ";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(216, 162);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(219, 27);
            this.txtIdade.TabIndex = 7;
            // 
            // rtbInfos
            // 
            this.rtbInfos.Location = new System.Drawing.Point(514, 67);
            this.rtbInfos.Name = "rtbInfos";
            this.rtbInfos.Size = new System.Drawing.Size(214, 209);
            this.rtbInfos.TabIndex = 8;
            this.rtbInfos.Text = "";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(511, 34);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(109, 18);
            this.lblDados.TabIndex = 10;
            this.lblDados.Text = "Seus dados:";
            this.lblDados.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.rtbInfos);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.RichTextBox rtbInfos;
        private System.Windows.Forms.Label lblDados;
    }
}

