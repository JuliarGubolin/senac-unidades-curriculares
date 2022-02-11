
namespace Relembrando_POO
{
    partial class FrmAgendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendar));
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbConv = new System.Windows.Forms.RadioButton();
            this.txtConv = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtSus = new System.Windows.Forms.TextBox();
            this.txtNconv = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.lblNconv = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblSus = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNomeM = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.txtEsp = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.lblEsp = new System.Windows.Forms.Label();
            this.ckbSus = new System.Windows.Forms.CheckBox();
            this.ckbConv = new System.Windows.Forms.CheckBox();
            this.ckbPart = new System.Windows.Forms.CheckBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgendar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendar.Image")));
            this.btnAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendar.Location = new System.Drawing.Point(427, 334);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(88, 45);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(11, 54);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 15);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário:";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(77, 83);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(119, 23);
            this.txtHora.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(47, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 15);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Agendamento de consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastro de paciente";
            // 
            // rdbConv
            // 
            this.rdbConv.AutoSize = true;
            this.rdbConv.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConv.Location = new System.Drawing.Point(457, 161);
            this.rdbConv.Name = "rdbConv";
            this.rdbConv.Size = new System.Drawing.Size(110, 19);
            this.rdbConv.TabIndex = 21;
            this.rdbConv.TabStop = true;
            this.rdbConv.Text = "Possui convênio";
            this.rdbConv.UseVisualStyleBackColor = true;
            // 
            // txtConv
            // 
            this.txtConv.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConv.Location = new System.Drawing.Point(575, 190);
            this.txtConv.Name = "txtConv";
            this.txtConv.Size = new System.Drawing.Size(100, 23);
            this.txtConv.TabIndex = 20;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(575, 94);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 23);
            this.txtRG.TabIndex = 19;
            // 
            // txtSus
            // 
            this.txtSus.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSus.Location = new System.Drawing.Point(575, 123);
            this.txtSus.Name = "txtSus";
            this.txtSus.Size = new System.Drawing.Size(100, 23);
            this.txtSus.TabIndex = 18;
            // 
            // txtNconv
            // 
            this.txtNconv.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNconv.Location = new System.Drawing.Point(575, 229);
            this.txtNconv.Name = "txtNconv";
            this.txtNconv.Size = new System.Drawing.Size(100, 23);
            this.txtNconv.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(575, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 16;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(454, 197);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(61, 15);
            this.lblConvenio.TabIndex = 15;
            this.lblConvenio.Text = "Convênio:";
            // 
            // lblNconv
            // 
            this.lblNconv.AutoSize = true;
            this.lblNconv.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNconv.Location = new System.Drawing.Point(454, 237);
            this.lblNconv.Name = "lblNconv";
            this.lblNconv.Size = new System.Drawing.Size(107, 15);
            this.lblNconv.TabIndex = 14;
            this.lblNconv.Text = "Número Convênio:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(454, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(454, 100);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(27, 15);
            this.lblRg.TabIndex = 24;
            this.lblRg.Text = "RG:";
            // 
            // lblSus
            // 
            this.lblSus.AutoSize = true;
            this.lblSus.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSus.Location = new System.Drawing.Point(454, 129);
            this.lblSus.Name = "lblSus";
            this.lblSus.Size = new System.Drawing.Size(33, 15);
            this.lblSus.TabIndex = 25;
            this.lblSus.Text = "SUS:";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.Location = new System.Drawing.Point(746, 101);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(37, 15);
            this.lblCRM.TabIndex = 37;
            this.lblCRM.Text = "CRM:";
            // 
            // lblNomeM
            // 
            this.lblNomeM.AutoSize = true;
            this.lblNomeM.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeM.Location = new System.Drawing.Point(746, 55);
            this.lblNomeM.Name = "lblNomeM";
            this.lblNomeM.Size = new System.Drawing.Size(43, 15);
            this.lblNomeM.TabIndex = 36;
            this.lblNomeM.Text = "Nome:";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(797, 9);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(114, 15);
            this.lblTitulo3.TabIndex = 35;
            this.lblTitulo3.Text = "Cadastro de médico";
            // 
            // txtEsp
            // 
            this.txtEsp.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEsp.Location = new System.Drawing.Point(847, 144);
            this.txtEsp.Name = "txtEsp";
            this.txtEsp.Size = new System.Drawing.Size(100, 23);
            this.txtEsp.TabIndex = 33;
            // 
            // txtCRM
            // 
            this.txtCRM.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRM.Location = new System.Drawing.Point(847, 94);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 23);
            this.txtCRM.TabIndex = 32;
            // 
            // txtNomeM
            // 
            this.txtNomeM.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeM.Location = new System.Drawing.Point(847, 51);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(100, 23);
            this.txtNomeM.TabIndex = 29;
            // 
            // lblEsp
            // 
            this.lblEsp.AutoSize = true;
            this.lblEsp.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsp.Location = new System.Drawing.Point(746, 152);
            this.lblEsp.Name = "lblEsp";
            this.lblEsp.Size = new System.Drawing.Size(82, 15);
            this.lblEsp.TabIndex = 28;
            this.lblEsp.Text = "Especialidade:";
            // 
            // ckbSus
            // 
            this.ckbSus.AutoSize = true;
            this.ckbSus.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSus.Location = new System.Drawing.Point(749, 206);
            this.ckbSus.Name = "ckbSus";
            this.ckbSus.Size = new System.Drawing.Size(49, 19);
            this.ckbSus.TabIndex = 38;
            this.ckbSus.Text = "SUS";
            this.ckbSus.UseVisualStyleBackColor = true;
            // 
            // ckbConv
            // 
            this.ckbConv.AutoSize = true;
            this.ckbConv.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbConv.Location = new System.Drawing.Point(847, 206);
            this.ckbConv.Name = "ckbConv";
            this.ckbConv.Size = new System.Drawing.Size(77, 19);
            this.ckbConv.TabIndex = 39;
            this.ckbConv.Text = "Convênio";
            this.ckbConv.UseVisualStyleBackColor = true;
            // 
            // ckbPart
            // 
            this.ckbPart.AutoSize = true;
            this.ckbPart.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPart.Location = new System.Drawing.Point(749, 240);
            this.ckbPart.Name = "ckbPart";
            this.ckbPart.Size = new System.Drawing.Size(77, 19);
            this.ckbPart.TabIndex = 40;
            this.ckbPart.Text = "Particular";
            this.ckbPart.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpData.Location = new System.Drawing.Point(77, 49);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(224, 20);
            this.dtpData.TabIndex = 41;
            this.dtpData.Value = new System.DateTime(2021, 10, 12, 0, 0, 0, 0);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(12, 152);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 15);
            this.lblDados.TabIndex = 42;
            // 
            // FrmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(956, 391);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.ckbPart);
            this.Controls.Add(this.ckbConv);
            this.Controls.Add(this.ckbSus);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.lblNomeM);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.txtEsp);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.txtNomeM);
            this.Controls.Add(this.lblEsp);
            this.Controls.Add(this.lblSus);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbConv);
            this.Controls.Add(this.txtConv);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtSus);
            this.Controls.Add(this.txtNconv);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblConvenio);
            this.Controls.Add(this.lblNconv);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnAgendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgendar";
            this.Text = "Agendar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbConv;
        private System.Windows.Forms.TextBox txtConv;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtSus;
        private System.Windows.Forms.TextBox txtNconv;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.Label lblNconv;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblSus;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblNomeM;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.TextBox txtEsp;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.Label lblEsp;
        private System.Windows.Forms.CheckBox ckbSus;
        private System.Windows.Forms.CheckBox ckbConv;
        private System.Windows.Forms.CheckBox ckbPart;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDados;
    }
}

