
namespace Aula3_Listas
{
    partial class frmPrincipal
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvListaPessoas = new System.Windows.Forms.DataGridView();
            this.txtCidades = new System.Windows.Forms.TextBox();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.btnCidades = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(652, 273);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 43);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(512, 283);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(93, 33);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "label1";
            // 
            // dgvListaPessoas
            // 
            this.dgvListaPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPessoas.Location = new System.Drawing.Point(376, 12);
            this.dgvListaPessoas.Name = "dgvListaPessoas";
            this.dgvListaPessoas.Size = new System.Drawing.Size(412, 249);
            this.dgvListaPessoas.TabIndex = 2;
            // 
            // txtCidades
            // 
            this.txtCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidades.Location = new System.Drawing.Point(12, 12);
            this.txtCidades.Multiline = true;
            this.txtCidades.Name = "txtCidades";
            this.txtCidades.Size = new System.Drawing.Size(206, 77);
            this.txtCidades.TabIndex = 3;
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(12, 119);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(206, 21);
            this.cbEstados.TabIndex = 4;
            this.cbEstados.SelectedIndexChanged += new System.EventHandler(this.cbEstados_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(247, 127);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(35, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "label1";
            this.lblEstado.Visible = false;
            // 
            // dgvCidades
            // 
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidades.Location = new System.Drawing.Point(376, 356);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.Size = new System.Drawing.Size(411, 225);
            this.dgvCidades.TabIndex = 6;
            // 
            // btnCidades
            // 
            this.btnCidades.Location = new System.Drawing.Point(518, 605);
            this.btnCidades.Name = "btnCidades";
            this.btnCidades.Size = new System.Drawing.Size(108, 38);
            this.btnCidades.TabIndex = 7;
            this.btnCidades.Text = "Confirmar Cidades";
            this.btnCidades.UseVisualStyleBackColor = true;
            this.btnCidades.Click += new System.EventHandler(this.btnCidades_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 273);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(118, 320);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(118, 370);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 424);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 276);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(33, 327);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(33, 377);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 14;
            this.lblIdade.Text = "Idade:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 431);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(93, 488);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(111, 55);
            this.btnCadastro.TabIndex = 16;
            this.btnCadastro.Text = "OK";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCidades);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.txtCidades);
            this.Controls.Add(this.dgvListaPessoas);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "frmPrincipal";
            this.Text = "Exercício Listas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DataGridView dgvListaPessoas;
        private System.Windows.Forms.TextBox txtCidades;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.Button btnCidades;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCadastro;
    }
}

