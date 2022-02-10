
namespace Relatório.UI
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rdbFm = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbOutro = new System.Windows.Forms.RadioButton();
            this.txtOutro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.btnCep = new System.Windows.Forms.Button();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(22, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 14);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(103, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(714, 165);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(72, 48);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(520, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 14);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.Location = new System.Drawing.Point(422, 442);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(61, 14);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Número:";
            this.lblAltura.Visible = false;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(23, 450);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 14);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(600, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAltura.Location = new System.Drawing.Point(525, 434);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(60, 22);
            this.txtAltura.TabIndex = 10;
            this.txtAltura.Visible = false;
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnd.Location = new System.Drawing.Point(126, 442);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(254, 22);
            this.txtEnd.TabIndex = 8;
            this.txtEnd.Visible = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(520, 74);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 14);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtFone
            // 
            this.txtFone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFone.Location = new System.Drawing.Point(600, 65);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(186, 22);
            this.txtFone.TabIndex = 7;
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.BackColor = System.Drawing.Color.Transparent;
            this.lblCid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCid.Location = new System.Drawing.Point(23, 489);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(56, 14);
            this.lblCid.TabIndex = 11;
            this.lblCid.Text = "Cidade:";
            this.lblCid.Visible = false;
            // 
            // txtCid
            // 
            this.txtCid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCid.Location = new System.Drawing.Point(126, 481);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(254, 22);
            this.txtCid.TabIndex = 12;
            this.txtCid.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.Location = new System.Drawing.Point(126, 524);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(254, 22);
            this.txtEstado.TabIndex = 14;
            this.txtEstado.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(23, 532);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 14);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Visible = false;
            // 
            // rdbFm
            // 
            this.rdbFm.AutoSize = true;
            this.rdbFm.BackColor = System.Drawing.Color.Transparent;
            this.rdbFm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFm.Location = new System.Drawing.Point(22, 105);
            this.rdbFm.Name = "rdbFm";
            this.rdbFm.Size = new System.Drawing.Size(81, 18);
            this.rdbFm.TabIndex = 2;
            this.rdbFm.TabStop = true;
            this.rdbFm.Text = "Feminino";
            this.rdbFm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Informações de endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(520, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contatos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dados pessoais:";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.BackColor = System.Drawing.Color.Transparent;
            this.rdbMasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbMasc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMasc.Location = new System.Drawing.Point(21, 129);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(86, 18);
            this.rdbMasc.TabIndex = 3;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = false;
            // 
            // rdbOutro
            // 
            this.rdbOutro.AutoSize = true;
            this.rdbOutro.BackColor = System.Drawing.Color.Transparent;
            this.rdbOutro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbOutro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbOutro.Location = new System.Drawing.Point(21, 153);
            this.rdbOutro.Name = "rdbOutro";
            this.rdbOutro.Size = new System.Drawing.Size(66, 18);
            this.rdbOutro.TabIndex = 5;
            this.rdbOutro.TabStop = true;
            this.rdbOutro.Text = "Outro:";
            this.rdbOutro.UseVisualStyleBackColor = false;
            this.rdbOutro.CheckedChanged += new System.EventHandler(this.rdbOutro_CheckedChanged);
            // 
            // txtOutro
            // 
            this.txtOutro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutro.Location = new System.Drawing.Point(21, 191);
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(147, 22);
            this.txtOutro.TabIndex = 6;
            this.txtOutro.Visible = false;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.Location = new System.Drawing.Point(421, 489);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 14);
            this.lblBairro.TabIndex = 24;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.Visible = false;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblComplemento.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplemento.Location = new System.Drawing.Point(420, 529);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(99, 14);
            this.lblComplemento.TabIndex = 25;
            this.lblComplemento.Text = "Complemento:";
            this.lblComplemento.Visible = false;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCEP.Location = new System.Drawing.Point(21, 376);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(37, 14);
            this.lblCEP.TabIndex = 26;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCEP.Location = new System.Drawing.Point(125, 371);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(164, 22);
            this.txtCEP.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(525, 481);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(254, 22);
            this.txtBairro.TabIndex = 28;
            this.txtBairro.Visible = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.Location = new System.Drawing.Point(525, 529);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(254, 22);
            this.txtComplemento.TabIndex = 11;
            this.txtComplemento.Visible = false;
            // 
            // btnCep
            // 
            this.btnCep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCep.Image = ((System.Drawing.Image)(resources.GetObject("btnCep.Image")));
            this.btnCep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCep.Location = new System.Drawing.Point(422, 338);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(115, 55);
            this.btnCep.TabIndex = 30;
            this.btnCep.Text = "Buscar CEP";
            this.btnCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCep.UseVisualStyleBackColor = false;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // dtpNasc
            // 
            this.dtpNasc.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(23, 279);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(99, 23);
            this.dtpNasc.TabIndex = 32;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNasc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNasc.Location = new System.Drawing.Point(23, 247);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(138, 14);
            this.lblDataNasc.TabIndex = 33;
            this.lblDataNasc.Text = "Data de nascimento:";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(798, 576);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtOutro);
            this.Controls.Add(this.rdbOutro);
            this.Controls.Add(this.rdbMasc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbFm);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rdbFm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rdbOutro;
        private System.Windows.Forms.TextBox txtOutro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label lblDataNasc;
    }
}