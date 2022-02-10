using Relatório.DAL;
using Relatório.MODEL;
using Relatório.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//FrmPessoas
namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        PessoasDAL pessoasDAL = new PessoasDAL();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNovaPessoa_Click(object sender, EventArgs e)
        {
            //Form SDI
            FrmCadastro cadastro = new FrmCadastro("Cadastro Nova Pessoa");
            cadastro.ShowDialog();

            //Preencher a grid de listagem
            PreencherGrid();
        }

        //Para listar as pessoas
        private void PreencherGrid()
        {
            dgvNomes.DataSource = null;
            dgvNomes.DataSource = pessoasDAL.Listar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void dgvNomes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Casting para pessoas (conversão explicita)
            var pessoa = (Pessoas)dgvNomes.Rows[e.RowIndex].DataBoundItem;
            FrmCadastro cadastro = new FrmCadastro("Alteração", pessoa.Codigo);
            cadastro.ShowDialog();
            PreencherGrid();
        }

        private void dgvNomes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var pessoa = (Pessoas)dgvNomes.SelectedRows[0].DataBoundItem;

            //Dialog Result 
            string msg = "Confirma a exlusão da pessoa " + pessoa.Nome + ", seu telefone e endereço?" ;
            string caption = "Remover Pessoa";
            var resultado = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                pessoasDAL.Excluir(pessoa.Codigo);
                PreencherGrid();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvNomes.DataSource = null;
            dgvNomes.DataSource = pessoasDAL.Pesquisar(txtNome.Text);
        }
    }
}
