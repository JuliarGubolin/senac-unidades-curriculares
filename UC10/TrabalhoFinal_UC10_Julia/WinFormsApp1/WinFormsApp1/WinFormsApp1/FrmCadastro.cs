using Relatório.DAL;
using Relatório.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Relatório.UI
{
    public partial class FrmCadastro : Form
    {
        //Declarando a DAL
        PessoasDAL pessoasDAL;
        public string msgSucesso;
        private int? codigo;
        public FrmCadastro(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;

            //Instanciar a DAL na construção do formulário 
            pessoasDAL = new PessoasDAL();
            rdbFm.Checked = false;
            rdbMasc.Checked = false;
            rdbOutro.Checked = false;
        }
        public FrmCadastro(string titulo, int codigo)
          :this(titulo)
        {
            this.codigo = codigo;
            var pessoas = pessoasDAL.ConsultarPorCodigo(codigo);
            txtNome.Text = pessoas.Nome;
            txtAltura.Text = Convert.ToString(pessoas.Numero);
            txtCEP.Text = pessoas.CEP;
            txtFone.Text = pessoas.Telefone;
            txtEmail.Text = pessoas.Email;
            txtEnd.Text = pessoas.Endereco;
            txtEstado.Text = pessoas.Estado;
            txtComplemento.Text = pessoas.Complemento;
            txtEstado.Visible = txtCid.Visible = txtAltura.Visible = txtBairro.Visible = txtComplemento.Visible = txtEnd.Visible = true;
            lblAltura.Visible = lblBairro.Visible = lblEstado.Visible = lblCid.Visible = lblComplemento.Visible = lblEndereco.Visible = true;
            txtCid.Text = pessoas.Cidade;
            txtBairro.Text = pessoas.Bairro;
            if (pessoas.Sexo == "Feminino")
            {
                rdbFm.Checked = true;
            }else if (pessoas.Sexo == "Masculino")
            {
                rdbMasc.Checked = true;
            }
            else
            {
                rdbOutro.Checked = true;
                txtOutro.Text = pessoas.Sexo;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCEP.Text == ""|| txtNome.Text == ""|| txtFone.Text == ""|| txtEmail.Text == "" || txtBairro.Text == "" || txtCid.Text == "" || txtEnd.Text == "" || txtEstado.Text == "" || txtAltura.Text == "")
            {
                msgSucesso = $"Preencha todos os campos!";
                MessageBox.Show(msgSucesso, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                string sexo;
                Pessoas pessoas = new Pessoas();
                pessoas.Nome = txtNome.Text;
                pessoas.Email = txtEmail.Text;
                pessoas.Numero = Convert.ToInt32(txtAltura.Text);
                pessoas.Endereco = txtEnd.Text;
                pessoas.Telefone = txtFone.Text;
                pessoas.Cidade = txtCid.Text;
                pessoas.Estado = txtEstado.Text;
                pessoas.CEP = txtCEP.Text;
                pessoas.Bairro = txtBairro.Text;
                pessoas.Complemento = txtComplemento.Text;
                pessoas.DataNasc = dtpNasc.Value.Day.ToString() + "/" + dtpNasc.Value.Month.ToString() + "/" + dtpNasc.Value.Year.ToString();
                if (rdbFm.Checked == true)
                {
                    sexo = "Feminino";

                } else if (rdbMasc.Checked == true)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = txtOutro.Text;
                }
                pessoas.Sexo = sexo;

                if (!codigo.HasValue)
                {
                    pessoasDAL.Inserir(pessoas);
                }
                else
                {
                    pessoas.Codigo = codigo.Value;
                    pessoasDAL.Alterar(pessoas);
                }

                msgSucesso = $"Você efetuou o cadastro com sucesso de: {txtNome.Text}.";
                MessageBox.Show(msgSucesso, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void rdbOutro_CheckedChanged(object sender, EventArgs e)
        {
            txtOutro.Visible = true;
        }

        private async void btnCep_Click(object sender, EventArgs e)
        {
            try
            {
                lblBairro.Visible = lblCid.Visible = lblComplemento.Visible = lblEstado.Visible = lblEndereco.Visible = lblComplemento.Visible = lblAltura.Visible = true;
                txtBairro.Visible = txtCid.Visible = txtComplemento.Visible = txtEstado.Visible = txtEnd.Visible = txtComplemento.Visible = txtAltura.Visible = true;
                var cep = txtCEP.Text;
                string tam, cep_1 = "", logradouro = "", bairro = "", complemento = "", localidade = "", uf = "", ibge = "", gia = "", ddd = "", siafi = "";
                int t, j = 0;
                if (!string.IsNullOrEmpty(cep))
                {
                    //Httpcliente = conector da internet
                    HttpClient clienteHttp = new HttpClient();
                    //await: espera o dado voltar
                    HttpResponseMessage mensagem = await clienteHttp.GetAsync("https://viacep.com.br/ws/" + cep + "/piped/");
                    mensagem.EnsureSuccessStatusCode();
                    tam = await mensagem.Content.ReadAsStringAsync();
                    t = tam.Length;
                    for (int i = 0; i < t; i++)
                    {
                        if (j == 0)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    cep_1 = cep_1 + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 1)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    logradouro = logradouro + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 2)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    complemento = complemento + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 3)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    bairro = bairro + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 4)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    localidade = localidade + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 5)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    uf = uf + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 6)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    ibge = ibge + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 7)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    gia = gia + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 8)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    ddd = ddd + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 9)
                        {

                            if (tam[i] == ':')
                            {
                                i++;
                                while (i < tam.Length)
                                {
                                    siafi = siafi + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                    }
                }
                txtBairro.Text = bairro;
                txtEstado.Text = uf;
                txtEnd.Text = logradouro;
                txtCid.Text = localidade;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
