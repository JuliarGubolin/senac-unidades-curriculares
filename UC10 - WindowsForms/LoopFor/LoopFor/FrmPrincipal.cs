using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopFor
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtNome.Select();
            txtNome.Focus();
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            int i, x;
            string repeteNome;
            repeteNome = txtNome.Text;
            x = Convert.ToInt32(txtRepetir.Text);
            for (i = 1; i<= x; i++)
            {
                cbbRepetir.Items.Add("Linha: "+i+", "+repeteNome);
            }
            lblResultado.Text = (i - 1) + " itens inseridos.";
        }
    }
}
