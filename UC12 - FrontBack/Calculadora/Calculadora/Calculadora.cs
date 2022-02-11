using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        List<double> listaNumeros = new List<double>();
        double valor1;
        double valor2;
        double result;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if ((txtValor1.Text == "" || txtValor2.Text == ""))
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);
                result = valor1 + valor2;
                lblResposta.Text = Convert.ToString(result);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if(txtValor1.Text == "" && txtValor2.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);
                result = valor1 - valor2;
                lblResposta.Text = Convert.ToString(result);
            }
            
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "" && txtValor2.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);
                result = valor1 * valor2;
                lblResposta.Text = Convert.ToString(result);
            }
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "" && txtValor2.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);
                result = valor1 / valor2;
                lblResposta.Text = Convert.ToString(result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);
            result = Math.Pow(valor1, valor2);
            lblResposta.Text = Convert.ToString(result);
        }
    }
}
