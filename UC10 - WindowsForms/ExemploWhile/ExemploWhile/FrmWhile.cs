using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWhile
{
    public partial class FrmWhile : Form
    {
        public FrmWhile()
        {
            InitializeComponent();
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            int contar = 1;
            while (contar <= 10)
            {
                cbbRepetir.Items.Add("Contando "+ contar);
                cbbRepetir.SelectedIndex = 0;
                lblResultado.Text = Convert.ToString(contar) + " linhas inseridas.";
                contar++;
            }
        }
    }
}
