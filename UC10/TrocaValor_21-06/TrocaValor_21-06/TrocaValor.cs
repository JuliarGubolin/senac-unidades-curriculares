using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaValor_21_06
{
    public partial class FrmTrocaValor : Form
    {
        public FrmTrocaValor()
        {
            InitializeComponent();
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            string aux1, aux2, aux3;
            aux1 = txtValor1.Text;
            aux2 = txtValor2.Text;
            aux3 = txtValor3.Text;
            txtValor1.Text = aux3;
            txtValor2.Text = aux1;
            txtValor3.Text = aux2;
            MessageBox.Show("Troca de valores concluída.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
