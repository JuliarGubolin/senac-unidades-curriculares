
namespace AumentoSalário
{
    partial class FrmReajuste
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
            this.components = new System.ComponentModel.Container();
            this.lblSalarioMin = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblHoraTrab = new System.Windows.Forms.Label();
            this.txtHorasTrab = new System.Windows.Forms.TextBox();
            this.gpbTurno = new System.Windows.Forms.GroupBox();
            this.rdbNoturno = new System.Windows.Forms.RadioButton();
            this.rdbVespertino = new System.Windows.Forms.RadioButton();
            this.rdbMatutino = new System.Windows.Forms.RadioButton();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.rdbEfetivo = new System.Windows.Forms.RadioButton();
            this.rdbCalouro = new System.Windows.Forms.RadioButton();
            this.ltbResultado = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.totSalario = new System.Windows.Forms.ToolTip(this.components);
            this.totHoras = new System.Windows.Forms.ToolTip(this.components);
            this.totResultado = new System.Windows.Forms.ToolTip(this.components);
            this.gpbTurno.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMin
            // 
            this.lblSalarioMin.AutoSize = true;
            this.lblSalarioMin.Location = new System.Drawing.Point(12, 19);
            this.lblSalarioMin.Name = "lblSalarioMin";
            this.lblSalarioMin.Size = new System.Drawing.Size(68, 13);
            this.lblSalarioMin.TabIndex = 0;
            this.lblSalarioMin.Text = "Salário Hora:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(140, 12);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(175, 20);
            this.txtSalario.TabIndex = 1;
            this.totSalario.SetToolTip(this.txtSalario, "Informe o valor do salário/hora atual");
            // 
            // lblHoraTrab
            // 
            this.lblHoraTrab.AutoSize = true;
            this.lblHoraTrab.Location = new System.Drawing.Point(12, 55);
            this.lblHoraTrab.Name = "lblHoraTrab";
            this.lblHoraTrab.Size = new System.Drawing.Size(96, 13);
            this.lblHoraTrab.TabIndex = 2;
            this.lblHoraTrab.Text = "Horas trabalhadas:";
            // 
            // txtHorasTrab
            // 
            this.txtHorasTrab.Location = new System.Drawing.Point(140, 48);
            this.txtHorasTrab.Name = "txtHorasTrab";
            this.txtHorasTrab.Size = new System.Drawing.Size(175, 20);
            this.txtHorasTrab.TabIndex = 3;
            this.totHoras.SetToolTip(this.txtHorasTrab, "Informe a quantidade de horas trabalhadas");
            // 
            // gpbTurno
            // 
            this.gpbTurno.Controls.Add(this.rdbNoturno);
            this.gpbTurno.Controls.Add(this.rdbVespertino);
            this.gpbTurno.Controls.Add(this.rdbMatutino);
            this.gpbTurno.Location = new System.Drawing.Point(355, 12);
            this.gpbTurno.Name = "gpbTurno";
            this.gpbTurno.Size = new System.Drawing.Size(121, 116);
            this.gpbTurno.TabIndex = 4;
            this.gpbTurno.TabStop = false;
            this.gpbTurno.Text = "Turno Trabalho";
            // 
            // rdbNoturno
            // 
            this.rdbNoturno.AutoSize = true;
            this.rdbNoturno.Location = new System.Drawing.Point(6, 81);
            this.rdbNoturno.Name = "rdbNoturno";
            this.rdbNoturno.Size = new System.Drawing.Size(63, 17);
            this.rdbNoturno.TabIndex = 2;
            this.rdbNoturno.TabStop = true;
            this.rdbNoturno.Text = "Noturno";
            this.rdbNoturno.UseVisualStyleBackColor = true;
            // 
            // rdbVespertino
            // 
            this.rdbVespertino.AutoSize = true;
            this.rdbVespertino.Location = new System.Drawing.Point(6, 58);
            this.rdbVespertino.Name = "rdbVespertino";
            this.rdbVespertino.Size = new System.Drawing.Size(75, 17);
            this.rdbVespertino.TabIndex = 1;
            this.rdbVespertino.TabStop = true;
            this.rdbVespertino.Text = "Vespertino";
            this.rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // rdbMatutino
            // 
            this.rdbMatutino.AutoSize = true;
            this.rdbMatutino.Location = new System.Drawing.Point(6, 31);
            this.rdbMatutino.Name = "rdbMatutino";
            this.rdbMatutino.Size = new System.Drawing.Size(66, 17);
            this.rdbMatutino.TabIndex = 0;
            this.rdbMatutino.TabStop = true;
            this.rdbMatutino.Text = "Matutino";
            this.rdbMatutino.UseVisualStyleBackColor = true;
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.rdbEfetivo);
            this.gpbCategoria.Controls.Add(this.rdbCalouro);
            this.gpbCategoria.Location = new System.Drawing.Point(15, 93);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(300, 64);
            this.gpbCategoria.TabIndex = 5;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoria";
            // 
            // rdbEfetivo
            // 
            this.rdbEfetivo.AutoSize = true;
            this.rdbEfetivo.Location = new System.Drawing.Point(217, 28);
            this.rdbEfetivo.Name = "rdbEfetivo";
            this.rdbEfetivo.Size = new System.Drawing.Size(58, 17);
            this.rdbEfetivo.TabIndex = 4;
            this.rdbEfetivo.TabStop = true;
            this.rdbEfetivo.Text = "Efetivo";
            this.rdbEfetivo.UseVisualStyleBackColor = true;
            // 
            // rdbCalouro
            // 
            this.rdbCalouro.AutoSize = true;
            this.rdbCalouro.Location = new System.Drawing.Point(6, 28);
            this.rdbCalouro.Name = "rdbCalouro";
            this.rdbCalouro.Size = new System.Drawing.Size(71, 17);
            this.rdbCalouro.TabIndex = 3;
            this.rdbCalouro.TabStop = true;
            this.rdbCalouro.Text = "Estagiário";
            this.rdbCalouro.UseVisualStyleBackColor = true;
            // 
            // ltbResultado
            // 
            this.ltbResultado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbResultado.FormattingEnabled = true;
            this.ltbResultado.ItemHeight = 14;
            this.ltbResultado.Location = new System.Drawing.Point(15, 175);
            this.ltbResultado.MultiColumn = true;
            this.ltbResultado.Name = "ltbResultado";
            this.ltbResultado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ltbResultado.Size = new System.Drawing.Size(464, 172);
            this.ltbResultado.TabIndex = 6;
            this.totResultado.SetToolTip(this.ltbResultado, "Mostra o resultado do cálculo");
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 364);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(151, 364);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSituacao
            // 
            this.txtSituacao.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSituacao.Location = new System.Drawing.Point(301, 366);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(175, 21);
            this.txtSituacao.TabIndex = 9;
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totSalario
            // 
            this.totSalario.IsBalloon = true;
            this.totSalario.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.totSalario.ToolTipTitle = "Ajuda";
            // 
            // totHoras
            // 
            this.totHoras.IsBalloon = true;
            this.totHoras.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.totHoras.ToolTipTitle = "Ajuda";
            // 
            // totResultado
            // 
            this.totResultado.IsBalloon = true;
            this.totResultado.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.totResultado.ToolTipTitle = "Ajuda";
            // 
            // FrmReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 405);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ltbResultado);
            this.Controls.Add(this.gpbCategoria);
            this.Controls.Add(this.gpbTurno);
            this.Controls.Add(this.txtHorasTrab);
            this.Controls.Add(this.lblHoraTrab);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalarioMin);
            this.Name = "FrmReajuste";
            this.Text = "Reajuste salarial";
            this.gpbTurno.ResumeLayout(false);
            this.gpbTurno.PerformLayout();
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioMin;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblHoraTrab;
        private System.Windows.Forms.TextBox txtHorasTrab;
        private System.Windows.Forms.GroupBox gpbTurno;
        private System.Windows.Forms.RadioButton rdbMatutino;
        private System.Windows.Forms.RadioButton rdbVespertino;
        private System.Windows.Forms.RadioButton rdbNoturno;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.RadioButton rdbCalouro;
        private System.Windows.Forms.RadioButton rdbEfetivo;
        private System.Windows.Forms.ListBox ltbResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.ToolTip totSalario;
        private System.Windows.Forms.ToolTip totHoras;
        private System.Windows.Forms.ToolTip totResultado;
    }
}

