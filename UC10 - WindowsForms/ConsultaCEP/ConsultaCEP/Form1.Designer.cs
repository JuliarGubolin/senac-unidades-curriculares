
namespace ConsultaCEP
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.btnCEP = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rtbEndereco = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(12, 20);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 15);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(59, 12);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(134, 23);
            this.txtCEP.TabIndex = 1;
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(214, 12);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(75, 23);
            this.btnCEP.TabIndex = 2;
            this.btnCEP.Text = "Consultar";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 115);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(38, 15);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // rtbEndereco
            // 
            this.rtbEndereco.Enabled = false;
            this.rtbEndereco.Location = new System.Drawing.Point(12, 146);
            this.rtbEndereco.Name = "rtbEndereco";
            this.rtbEndereco.Size = new System.Drawing.Size(463, 192);
            this.rtbEndereco.TabIndex = 4;
            this.rtbEndereco.Text = "";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 406);
            this.Controls.Add(this.rtbEndereco);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCEP);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.Text = "Consulta CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RichTextBox rtbEndereco;
    }
}

