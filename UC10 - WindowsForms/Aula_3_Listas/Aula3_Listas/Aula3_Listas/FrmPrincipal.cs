using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3_Listas
{
    public partial class frmPrincipal : Form
    {
        List<Cliente> listaCliente = new List<Cliente>();
        List<Estado> listaEstados;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Declaração da lista de strings exemplo
            //List<tipoDado> nomeLista;
            
            //Instanciar a lista
            listaCliente = new List<Cliente>
            {
                new Cliente {Id = 1, Nome = "Julia", Email = "julia@gmail.com", Idade = 17},
                new Cliente {Id = 2, Nome = "Reginaldo", Email = "reginaldo@gmail.com", Idade = 18},
                new Cliente {Id = 3, Nome = "Pedro", Email = "pedro@gmail.com", Idade = 19},
                new Cliente {Id = 4, Nome = "Patrick", Email = "patrick@gmail.com", Idade = 20},
                new Cliente {Id = 5, Nome = "William", Email = "will@gmail.com", Idade = 21},
                new Cliente {Id = 6, Nome = "Gabriel", Email = "gabrielo@gmail.com", Idade = 22},
                new Cliente {Id = 7, Nome = "Professor", Email = "professor@gmail.com", Idade = 23}
            };

            //Popular o DataGridView
            dgvListaPessoas.DataSource = listaCliente;
            //Comatr quantos elementos tem na lista
            lblQuantidade.Text = listaCliente.Count.ToString() +  " Alunos" ;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Instanciar
            listaEstados = new List<Estado>();
            //Carregar o Combo Box
            //Listar na combo box os estados que eu quero
            listaEstados.Add(new Estado() { Id = 1, UF = "São Paulo" });
            listaEstados.Add(new Estado() { Id = 2, UF = "Rio de Janeiro" });
            listaEstados.Add(new Estado() { Id = 3, UF = "Amazonas" });
            cbEstados.DataSource = listaEstados;
            cbEstados.ValueMember = "ID";
            cbEstados.DisplayMember = "UF";
        }

        private void cbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEstado.Visible = true;
            lblEstado.Text = cbEstados.Text;
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            List<Cidade> listaCidade = new List<Cidade>();
            listaCidade.Add(new Cidade() { NomeCidade = txtCidades.Text });
            //Outra forma de fazer
            /*listaCidade = new List<Cidade>
            {
                new Cidade { NomeCidade = txtCidades.Text }
            };*/
            dgvCidades.DataSource = listaCidade;
            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome, email;
            int idade, Id;
            idade = Convert.ToInt32(txtIdade.Text);
            Id = Convert.ToInt32(txtId.Text);
            nome = txtNome.Text;
            email = txtEmail.Text;
            listaCliente.Add(new Cliente() {Id = Id, Nome = nome, Email = email, Idade = idade});
            //dgvListaPessoas.DataSource = listaCliente;
        }
    }
}
