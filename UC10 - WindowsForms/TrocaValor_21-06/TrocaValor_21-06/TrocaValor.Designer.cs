
namespace TrocaValor_21_06
{
    partial class FrmTrocaValor
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnTroca = new System.Windows.Forms.Button();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(12, 9);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(57, 17);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(99, 6);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(260, 23);
            this.txtValor1.TabIndex = 1;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(12, 87);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(57, 17);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "Valor 2:";
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(99, 84);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(260, 23);
            this.txtValor2.TabIndex = 3;
            // 
            // btnTroca
            // 
            this.btnTroca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroca.Location = new System.Drawing.Point(423, 73);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(171, 44);
            this.btnTroca.TabIndex = 4;
            this.btnTroca.Text = "Trocar";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor3.Location = new System.Drawing.Point(12, 165);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(57, 17);
            this.lblValor3.TabIndex = 5;
            this.lblValor3.Text = "Valor 3:";
            // 
            // txtValor3
            // 
            this.txtValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor3.Location = new System.Drawing.Point(99, 162);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(260, 23);
            this.txtValor3.TabIndex = 6;
            // 
            // FrmTrocaValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 351);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.btnTroca);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor1);
            this.Name = "FrmTrocaValor";
            this.Text = "Troca de Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnTroca;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.TextBox txtValor3;
    }
}

