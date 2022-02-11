
namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(129, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 14);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora em C#";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor1.Location = new System.Drawing.Point(31, 73);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(55, 14);
            this.lblValor1.TabIndex = 1;
            this.lblValor1.Text = "Valor 1:";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor2.Location = new System.Drawing.Point(29, 112);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(55, 14);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "Valor 2:";
            // 
            // txtValor1
            // 
            this.txtValor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtValor1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor1.Location = new System.Drawing.Point(91, 70);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 22);
            this.txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            this.txtValor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtValor2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor2.Location = new System.Drawing.Point(91, 108);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 4;
            // 
            // btnSoma
            // 
            this.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoma.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.Location = new System.Drawing.Point(278, 29);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(92, 23);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(278, 67);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(92, 23);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "Subtração";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMul.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMul.Location = new System.Drawing.Point(278, 108);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(92, 23);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "Multiplicação";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivisão.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivisão.Location = new System.Drawing.Point(278, 146);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(92, 23);
            this.btnDivisão.TabIndex = 8;
            this.btnDivisão.Text = "Divisão";
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Click += new System.EventHandler(this.btnDivisão_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResposta.Location = new System.Drawing.Point(91, 150);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 14);
            this.lblResposta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Resultado:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(278, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Potenciação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(407, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnDivisão);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora em C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

