
namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovaPessoa = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvNomes = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblTabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(23, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 14);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(330, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(106, 41);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovaPessoa
            // 
            this.btnNovaPessoa.BackColor = System.Drawing.Color.LightGreen;
            this.btnNovaPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaPessoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovaPessoa.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaPessoa.Image")));
            this.btnNovaPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaPessoa.Location = new System.Drawing.Point(828, 13);
            this.btnNovaPessoa.Name = "btnNovaPessoa";
            this.btnNovaPessoa.Size = new System.Drawing.Size(128, 41);
            this.btnNovaPessoa.TabIndex = 2;
            this.btnNovaPessoa.Text = "Nova Pessoa";
            this.btnNovaPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaPessoa.UseVisualStyleBackColor = false;
            this.btnNovaPessoa.Click += new System.EventHandler(this.btnNovaPessoa_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 23);
            this.txtNome.TabIndex = 3;
            // 
            // dgvNomes
            // 
            this.dgvNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomes.Location = new System.Drawing.Point(12, 150);
            this.dgvNomes.Name = "dgvNomes";
            this.dgvNomes.RowTemplate.Height = 25;
            this.dgvNomes.Size = new System.Drawing.Size(944, 304);
            this.dgvNomes.TabIndex = 4;
            this.dgvNomes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNomes_CellContentClick);
            this.dgvNomes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNomes_CellDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(828, 60);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 42);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.BackColor = System.Drawing.Color.Transparent;
            this.lblTabela.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTabela.Location = new System.Drawing.Point(12, 118);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(171, 18);
            this.lblTabela.TabIndex = 6;
            this.lblTabela.Text = "Tabela de listagem:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(968, 467);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvNomes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNovaPessoa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulação de Pessoas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovaPessoa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvNomes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblTabela;
    }
}