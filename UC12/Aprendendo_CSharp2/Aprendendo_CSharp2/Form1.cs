using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendendo_CSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Título do formulário";
            btnExibir.Text = "Exibir";
            label1.Text = "Nome do texto";
            label1.Click += Label1_Click;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            btnExibir.Hide();
            ExibirMensagem("Título 1", "Mensagem 1");
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            label1.Hide();
            ExibirMensagem("Título 2", "Mensagem 2");
        }

        //Funções
        //Métodos próprios

        private void ExibirMensagem(string titulo, string mensagem)
        {
            //Objeto
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK);

        }
    }
}
