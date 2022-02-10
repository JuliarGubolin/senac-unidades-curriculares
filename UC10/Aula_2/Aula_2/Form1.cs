using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string idade = txtIdade.Text;
            if (idade == "" || endereco == "" || idade == "")
            {
                MessageBox.Show("Preencha todos os campos!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                //MessageBox.Show($"Olá, {nome}. Você possui {idade} anos e mora em {endereco}.", "Dados recebidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rtbInfos.Text = nome+"\n"+idade+"\n"+endereco;
                lblDados.Visible = true;
            }
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
